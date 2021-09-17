using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayipanel
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

       
        public string firmaAd, faaliyet, adres, mail, tel, vergiDairesi, vergiNo, yetkiliAd, yetkiliSoyad, yetkiliUnvan, yetkiliTel, butonDurum;
        public int firmaId = 0;
        public string startDurumDeger;
        string deger;




        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text.Contains("@") && txtMail.Text.Contains(".com"))
            {
            }
            else
            {
                MessageBox.Show("Lütfen mail formatında yazın");
            }
        }



        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        private void btnFirmaDuzen_Click(object sender, EventArgs e)
        {
            if (txtFirmaAd.Text == "" && txtFaaliyet.Text == "" && txtAdres.Text == "" && txtMail.Text == "" && txtTel.Text == "" && txtVergiDaire.Text == "" && txtVergiNo.Text == "" && txtYetkiliAd.Text == "" && txtYetkiliSoyad.Text == "" && txtYetkiliUnvan.Text == "")
            {
            }
            else if (txtFirmaAd.Text == "" || txtFaaliyet.Text == "" || txtAdres.Text == "" || txtMail.Text == "" || txtTel.Text == "" || txtVergiDaire.Text == "" || txtVergiNo.Text == "" || txtYetkiliAd.Text == "" || txtYetkiliSoyad.Text == "" || txtYetkiliUnvan.Text == "")
            {
            }
            else
            {
                veritabani cagir = new veritabani();
                if (cbDurum.Checked == true)
                {
                    deger = "ONAYLANDI";
                }
                else
                {
                    deger = "ONAYLANMADI";
                }
                cagir.FirmaDüzenle(firmaId, txtFirmaAd.Text, txtFaaliyet.Text, txtAdres.Text, txtMail.Text, txtTel.Text, txtVergiDaire.Text, long.Parse(txtVergiNo.Text), txtYetkiliAd.Text, txtYetkiliSoyad.Text, txtYetkiliUnvan.Text, txtYetkiliTel.Text, deger);

                Start start = (Start)Application.OpenForms["Start"];
                start.firmaTabloDoldur();
                this.Close();
            }
        }




        private void btnFirmaEkle_Click_1(object sender, EventArgs e)
        {
            if (txtFirmaAd.Text=="" && txtFaaliyet.Text=="" && txtAdres.Text=="" && txtMail.Text=="" && txtTel.Text=="" && txtVergiDaire.Text=="" && txtVergiNo.Text=="" && txtYetkiliAd.Text=="" && txtYetkiliSoyad.Text=="" && txtYetkiliUnvan.Text=="")
            {
            }
            else if(txtFirmaAd.Text == "" || txtFaaliyet.Text == "" || txtAdres.Text == "" || txtMail.Text == "" || txtTel.Text == "" || txtVergiDaire.Text == "" || txtVergiNo.Text == "" || txtYetkiliAd.Text == "" || txtYetkiliSoyad.Text == "" || txtYetkiliUnvan.Text == "")
            {
            }
            else
            {
                if (cbDurum.Checked == true)
                {
                    deger = "ONAYLANDI";
                }
                else
                {
                    deger = "ONAYLANMADI";
                }
                veritabani cagir = new veritabani();
                cagir.FirmaEkle(txtFirmaAd.Text, txtFaaliyet.Text, txtAdres.Text, txtMail.Text, txtTel.Text, txtVergiDaire.Text, long.Parse(txtVergiNo.Text), txtYetkiliAd.Text, txtYetkiliSoyad.Text, txtYetkiliUnvan.Text, txtYetkiliTel.Text, deger);

                Start start = (Start)Application.OpenForms["Start"];
                start.firmaTabloDoldur();
                this.Close();
            }
        }




        private void Ekle_Load(object sender, EventArgs e)
        {          
            txtFirmaAd.Text = firmaAd;
            txtFaaliyet.Text = faaliyet;
            txtAdres.Text = adres;
            txtMail.Text = mail;
            txtTel.Text = tel;
            txtVergiDaire.Text = vergiDairesi;
            txtVergiNo.Text = vergiNo;
            txtYetkiliAd.Text = yetkiliAd;
            txtYetkiliSoyad.Text = yetkiliSoyad;
            txtYetkiliUnvan.Text = yetkiliUnvan;
            txtYetkiliTel.Text = yetkiliTel;
            
            if (butonDurum=="1")
            {
                btnFirmaDuzen.Visible = false;
            }
            else
            {
                if (startDurumDeger=="ONAYLANDI")
                {
                    cbDurum.Checked = true;
                }              
                btnFirmaEkle.Visible = false;
            }
        }
    }
}
