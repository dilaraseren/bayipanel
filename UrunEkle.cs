using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bayipanel
{
    public partial class UrunEkle : Form
    {

        public UrunEkle()
        {
            InitializeComponent();
        }

        

        public int urunEklefirmaId, urunButonDurum, ekleUrunId, komisyonT, tutr;
        public string ack, progT, satisT, kayitT, tarihTut, cbProgramTipTut;




        private void cbProgramTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProgramTipTut = cbProgramTip.SelectedItem.ToString();
        }



        public void ProgramTipGetir()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=bayipanel;Uid=root;Pwd='1234';");
            try
            {
                baglanti.Open();
                cmd.CommandText = "SELECT  * FROM programtipi";
                cmd.Connection = baglanti;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbProgramTip.Items.Add(dr["programAd"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
            baglanti.Close();
        }



        private void chkTarihSeçim_Click(object sender, EventArgs e)
        {
            if (chkTarihSeçim.Checked==true)
            {
                dtSatisTarih.Enabled = true;
            }
            else
            {
                dtSatisTarih.Enabled = false;
            }
        }

        


        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
        private void txtKomisyonTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        
        

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            if (urunButonDurum == 1)
            {
                dtSatisTarih.Enabled = false;
                ProgramTipGetir();
                btnUrunDuzenle.Visible = false;
            }
            else
            {
                if (satisT=="")
                {
                    dtSatisTarih.Enabled = false;
                    
                }
                else
                {
                    chkTarihSeçim.Checked = true;
                    dtSatisTarih.Value = Convert.ToDateTime(satisT);
                }             
                dtKayitTarih.Value = Convert.ToDateTime(kayitT);
                txtTutar.Text = tutr.ToString();
                txtKomisyonTutar.Text = komisyonT.ToString();               
                cbProgramTip.SelectedText = progT;
                ProgramTipGetir();
                txtAciklama.Text = ack;
                btnUrunEkle.Visible = false;
            }
        }




        
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();

            if (chkTarihSeçim.Checked == true)
            {
                tarihTut = dtSatisTarih.Value.ToString();
            }
            else
            {
                tarihTut = null;
                
            }

            cagir.FirmaUrunEkle(urunEklefirmaId, tarihTut, dtKayitTarih.Value,Convert.ToInt32(txtTutar.Text), Convert.ToInt32(txtKomisyonTutar.Text), cbProgramTip.SelectedItem.ToString(), DateTime.Now,txtAciklama.Text);

            FirmaUrunBilgi firmaUrun = (FirmaUrunBilgi)Application.OpenForms["FirmaUrunBilgi"];
            firmaUrun.TabloCek();
            firmaUrun.ToplamTutar();
            firmaUrun.ToplamSatisAdeti();
            this.Close();
        }




        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            if (chkTarihSeçim.Checked == true )
            {
                tarihTut = dtSatisTarih.Value.ToString();
            }
            else
            {
                tarihTut = null;

            }
            if (cbProgramTipTut==null)
            {
                cbProgramTipTut = cbProgramTip.Text.ToString();
            }
            else
            {
            }           
            cagir.FirmaUrunDüzenle(ekleUrunId, tarihTut, dtKayitTarih.Value,Convert.ToInt32(txtTutar.Text),Convert.ToInt32(txtKomisyonTutar.Text), cbProgramTipTut, DateTime.Now, txtAciklama.Text);
            FirmaUrunBilgi firmaUrun = (FirmaUrunBilgi)Application.OpenForms["FirmaUrunBilgi"];
            firmaUrun.TabloCek();
            firmaUrun.ToplamTutar();
            firmaUrun.ToplamSatisAdeti();
            this.Close();
        }
    }
}
