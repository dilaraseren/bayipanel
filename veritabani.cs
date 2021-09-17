using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bayipanel
{
    class veritabani
    {

        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlConnection baglanti= new MySqlConnection("Server=localhost;Database=bayipanel;Uid=root;Pwd='1234';");



        public int Login(string kullaniciAd, int sifre)
        {

            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM kullanici where kullaniciAd='" + kullaniciAd + "' AND sifre='" + sifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                return 1;              
            }
            else
            {
                baglanti.Close();
                return 0;
            }         
        }



        public DataTable FirmaTabloCek()
        {
            try
            {                                      
                cmd.CommandText = "SELECT * FROM firma";
                cmd.Connection = baglanti;
                da.SelectCommand = cmd;
                baglanti.Open();

                da.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }          
        }





        public DataTable SuresiBiten(int firmaId,string kayitTarih)
        {
            try
            {
                cmd.CommandText = "select * from urun where kayitTarih >= @kayitTarih and firmaId=@firmaId and satisTarih is null";
                cmd.Parameters.AddWithValue("@kayitTarih", Convert.ToDateTime(kayitTarih));
                cmd.Parameters.AddWithValue("@firmaId", firmaId);
                cmd.Connection = baglanti;
                da.SelectCommand = cmd;
                baglanti.Open();

                da.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }
        }



        public DataTable EvrakDurumunaGöreTabloGetir(string durum)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM firma where durum=@durum";
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Connection = baglanti;
                da.SelectCommand = cmd;
                baglanti.Open();

                da.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }
        }




        public DataTable FirmaAra(string deger)
        {
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from firma  where firmaAd like'%" + deger + "%' or faaliyet like '%" + deger + "%' or adres like '%" + deger + "%' or mail like '%" + deger + "%' or tel like '%" + deger + "%' or vergiDairesi like '%" + deger + "%' or vergiNo like '%" + deger + "%' or firmaYetkiliAd like '%" + deger + "%' or firmaYetkiliSoyad like '%" + deger + "%' or yetkiliUnvan like '%" + deger + "%' or yetkiliTel like '%" + deger + "%'";
                da.SelectCommand = cmd;
                baglanti.Open();

                da.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }
        }



        public int FirmaEkle(string firmaAd, string faaliyet, string adres, string mail, string tel, string vergidaire, long vergiNo, string yetkiliAd, string yetkiliSoyad, string yetkiliUnvan, string yetkiliTel, string durum)
        {

            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into firma(firmaAd, faaliyet, adres, mail, tel, vergiDairesi, vergiNo, firmaYetkiliAd, firmaYetkiliSoyad, yetkiliUnvan, yetkiliTel, durum) values (@firmaAd, @faaliyet, @adres, @mail, @tel, @vergiDairesi, @vergiNo, @firmaYetkiliAd, @firmaYetkiliSoyad, @yetkiliUnvan, @yetkiliTel, @durum)";
            cmd.Parameters.AddWithValue("@firmaAd", firmaAd);
            cmd.Parameters.AddWithValue("@faaliyet", faaliyet);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@vergiDairesi", vergidaire);
            cmd.Parameters.AddWithValue("@vergiNo", vergiNo);
            cmd.Parameters.AddWithValue("@firmaYetkiliAd", yetkiliAd);
            cmd.Parameters.AddWithValue("@firmaYetkiliSoyad", yetkiliSoyad);
            cmd.Parameters.AddWithValue("@yetkiliUnvan", yetkiliUnvan);
            cmd.Parameters.AddWithValue("@yetkiliTel", yetkiliTel);
            cmd.Parameters.AddWithValue("@durum", durum);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                return 1;
            }
            else
            {
                baglanti.Close();
                return 0;
            }


        }



        public void FirmaSil(string Id)
        {
            
            try
            {
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM firma WHERE firmaId=@firmaId";   
                //cmd.CommandText = "DELETE firma, urun FROM firma INNER JOIN urun ON firma.firmaId = urun.firmaId where firma.firmaId=@firmaId";
                cmd.Parameters.AddWithValue("@firmaId", Convert.ToInt32(Id));
                cmd.CommandType = CommandType.Text;
                
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }



        public void FirmaUrunuSil(string Id)
        {

            try
            {
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM urun WHERE firmaId=@firmaId";
                cmd.Parameters.AddWithValue("@firmaId", Convert.ToInt32(Id));
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }




        public void FirmaDüzenle(int Id, string firmaAd, string faaliyet, string adres, string mail, string tel, string vergidaire, long vergiNo, string yetkiliAd, string yetkiliSoyad, string yetkiliUnvan, string yetkiliTel, string durum)
        {               

            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "update firma set firmaAd = '" + firmaAd + "',faaliyet = '" + faaliyet + "', adres = '" + adres + "', mail = '" + mail + "', tel = '" + tel + "', vergiDairesi = '" + vergidaire + "', vergiNo = " + vergiNo + ", firmaYetkiliAd = '" + yetkiliAd + "', firmaYetkiliSoyad = '" + yetkiliSoyad + "', yetkiliUnvan = '" + yetkiliUnvan + "', yetkiliTel = '" + yetkiliTel + "', durum = '" + durum + "' where firmaId = '" + Id + "' ";

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }




        public DataTable FirmaUrunTabloCek(int firmaId)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM urun where firmaId = '" + firmaId + "'";
                cmd.Connection = baglanti;
                da.SelectCommand = cmd;
                baglanti.Open();

                da.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }
        }




        public int FirmaUrunEkle(int firmaId,string satisTarih, DateTime kayitTarih, int tutar, int komisyonTutar, string programTip, DateTime tarih, string aciklama)
        {

            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "insert into urun(firmaId, satisTarih, kayitTarih, tutar, komisyonTutar, programTip, tarih, aciklama) values (@firmaId, @satisTarih, @kayitTarih, @tutar, @komisyonTutar, @programTip, @tarih, @aciklama)";
            cmd.Parameters.AddWithValue("@firmaId", firmaId);
            cmd.Parameters.AddWithValue("@satisTarih", satisTarih);
            cmd.Parameters.AddWithValue("@kayitTarih", kayitTarih);
            cmd.Parameters.AddWithValue("@tutar", tutar);
            cmd.Parameters.AddWithValue("@komisyonTutar", komisyonTutar);
            cmd.Parameters.AddWithValue("@programTip", programTip);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            cmd.Parameters.AddWithValue("@aciklama", aciklama);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                return 1;
            }
            else
            {
                baglanti.Close();
                return 0;
            }


        }




        public void FirmaUrunDüzenle(int urunId, string satisTarih, DateTime kayitTarih, int tutar, int komisyonTutar, string programTipi, DateTime tarih, string aciklama)
        {

            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "update urun set  satisTarih=@satisTarih , kayitTarih=@kayitTarih , tutar=@tutar , komisyonTutar=@komisyonTutar , programTip=@programTip , tarih=@tarih , aciklama=@aciklama where urunId = @urunId";

                cmd.Parameters.AddWithValue("@satisTarih", satisTarih);
                cmd.Parameters.AddWithValue("@kayitTarih", kayitTarih);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@komisyonTutar", komisyonTutar);
                cmd.Parameters.AddWithValue("@programTip", programTipi);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@urunId", urunId);


                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }




        public void UrunSil(string Id)
        {

            try
            {
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM urun WHERE urunId=@urunId";
                cmd.Parameters.AddWithValue("@urunId", Convert.ToInt32(Id));
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }





        string deger;
        public string  TarihGetir(int Id)
        {
            
            try
            {
                baglanti.Open();
                cmd.CommandText = "SELECT  satisTarih FROM urun  where firmaId = '" + Id + "' order by satisTarih asc";
                cmd.Connection = baglanti;
                
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    deger = dr["satisTarih"].ToString();
                }
                baglanti.Close();
                return deger;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
                return null;
            }

        }



    }
}
