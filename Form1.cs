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
    public partial class Form1 : Form
    {
        
        char? none = null;
        int deger = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public void Log()
        {
            veritabani cagir = new veritabani();
            deger = cagir.Login(txtkullaniciAd.Text.Trim(), Convert.ToInt32(txtsifre.Text.Trim()));
            if (deger == 1)
            {
                Start start = new Start();
                this.Hide();
                start.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol edin.");
                txtkullaniciAd.Text = "";
                txtsifre.Text = "";
            }
        }
 
 
        
        private void txtkullaniciAd_Enter(object sender, EventArgs e)
        {
            if (txtkullaniciAd.Text == "Kullanıcı adı")
            {
                txtkullaniciAd.Text = "";
            }
        }
        private void txtkullaniciAd_Leave(object sender, EventArgs e)
        {
            if (txtkullaniciAd.Text == "")
            {
                txtkullaniciAd.Text = "Kullanıcı adı";
            }
        }
        private void txtsifre_Enter(object sender, EventArgs e)
        {
            if (txtsifre.Text == "Password")
            {
                txtsifre.Text = "";
                txtsifre.PasswordChar = '*';
            }
        }
        private void txtsifre_Leave(object sender, EventArgs e)
        {
            if (txtsifre.Text == "")
            {
                txtsifre.Text = "Password";
                txtsifre.PasswordChar = Convert.ToChar(none);
            }
        }





        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtkullaniciAd.Text== "Kullanıcı adı" && txtsifre.Text == "Password")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else if (txtkullaniciAd.Text == "" && txtsifre.Text == "Password")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else if (txtkullaniciAd.Text == "Kullanıcı adı" && txtsifre.Text == "")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else if (txtkullaniciAd.Text == "" || txtsifre.Text=="")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else if (txtkullaniciAd.Text == "Kullanıcı adı")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else if (txtsifre.Text == "Password")
            {
                MessageBox.Show("Alanları doldurun.");
            }
            else
            {
                Log();
            }             
        }



        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
