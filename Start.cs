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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        
        int  butonDurum;




        public void firmaTabloDoldur()
        {
            veritabani cagir = new veritabani();
            dtgFirmaTablo.DataSource = cagir.FirmaTabloCek();
            
            lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
            this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
        }




        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            butonDurum = 1;

            Ekle EkleForm = new Ekle();
            EkleForm.butonDurum = butonDurum.ToString();
            EkleForm.Show();
        }



        private void btnFirmaDuzen_Click(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            butonDurum = 0;

            Ekle EkleForm = new Ekle();
            EkleForm.firmaId= Convert.ToInt32(dtgFirmaTablo.CurrentRow.Cells["firmaId"].Value.ToString());
            EkleForm.firmaAd = dtgFirmaTablo.CurrentRow.Cells["firmaAd"].Value.ToString();
            EkleForm.faaliyet = dtgFirmaTablo.CurrentRow.Cells["faaliyet"].Value.ToString();
            EkleForm.adres = dtgFirmaTablo.CurrentRow.Cells["adres"].Value.ToString();
            EkleForm.mail = dtgFirmaTablo.CurrentRow.Cells["mail"].Value.ToString();
            EkleForm.tel = dtgFirmaTablo.CurrentRow.Cells["tel"].Value.ToString();
            EkleForm.vergiDairesi = dtgFirmaTablo.CurrentRow.Cells["vergiDairesi"].Value.ToString();
            EkleForm.vergiNo = dtgFirmaTablo.CurrentRow.Cells["vergiNo"].Value.ToString();
            EkleForm.yetkiliAd = dtgFirmaTablo.CurrentRow.Cells["firmaYetkiliAd"].Value.ToString();
            EkleForm.yetkiliSoyad = dtgFirmaTablo.CurrentRow.Cells["firmaYetkiliSoyad"].Value.ToString();
            EkleForm.yetkiliUnvan = dtgFirmaTablo.CurrentRow.Cells["yetkiliUnvan"].Value.ToString();
            EkleForm.yetkiliTel = dtgFirmaTablo.CurrentRow.Cells["yetkiliTel"].Value.ToString();

            if (dtgFirmaTablo.CurrentRow.Cells["durum"].Value.ToString()=="ONAYLANDI")
            {
                EkleForm.startDurumDeger = "ONAYLANDI";
            }
            else
            {
                EkleForm.startDurumDeger = "ONAYLANMADI";
            }
            EkleForm.butonDurum = butonDurum.ToString();
            EkleForm.Show();
        }




        private void btnFUrunBilgi_Click(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            FirmaUrunBilgi bilgi = new FirmaUrunBilgi();
            bilgi.urunBilgiFirmaId = Convert.ToInt32(dtgFirmaTablo.CurrentRow.Cells["firmaId"].Value.ToString());
            bilgi.urunBilgiFirmaAd = dtgFirmaTablo.CurrentRow.Cells["firmaAd"].Value.ToString();
            bilgi.Show();
        }





        private void Start_Load(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            dtgFirmaTablo.DataSource = cagir.FirmaTabloCek();

            lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
            this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
            dtgFirmaTablo.RowHeadersVisible = false;
            btnFirmaSil.Enabled = false;
        }



        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Firma kaydını silmek istediğinizden emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                //Kayıt sil işlemi
                veritabani cagir = new veritabani();

                cagir.FirmaSil(dtgFirmaTablo.CurrentRow.Cells["firmaId"].Value.ToString());
                dtgFirmaTablo.DataSource = cagir.FirmaTabloCek();
                lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
                this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
            }
            else if (secenek == DialogResult.No)
            {
               
            }          
        }

   
        
        private void txtFirmaAra_Enter(object sender, EventArgs e)
        {
            if (txtFirmaAra.Text == "Firma alanları...")
            {
                txtFirmaAra.Text = "";
                txtFirmaAra.ForeColor = Color.Black;
            }
        }
        private void txtFirmaAra_Leave(object sender, EventArgs e)
        {
            if (txtFirmaAra.Text == "")
            {
                txtFirmaAra.Text = "Firma alanları...";
                txtFirmaAra.ForeColor = Color.Gray;

                veritabani cagir = new veritabani();
                dtgFirmaTablo.DataSource = cagir.FirmaTabloCek();

                lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
                this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
                btnFirmaSil.Enabled = false;
            }
        }


        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            dtgFirmaTablo.DataSource = cagir.FirmaAra(txtFirmaAra.Text);

            lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
            this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
        }



        private void dtgFirmaTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            veritabani cagir = new veritabani();
            int secilen = dtgFirmaTablo.SelectedCells[0].RowIndex;
            lstFirmaYekili.Text = dtgFirmaTablo.Rows[secilen].Cells[8].Value.ToString() + " " + dtgFirmaTablo.Rows[secilen].Cells[9].Value.ToString();
            lstYetkiliTel.Text = dtgFirmaTablo.Rows[secilen].Cells[11].Value.ToString();
            lstYetkiliUnvan.Text = dtgFirmaTablo.Rows[secilen].Cells[10].Value.ToString();
            btnFirmaSil.Enabled = true;
        }




        private void cbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSecim.SelectedItem.ToString()=="ONAYLANDI")
            {
                veritabani cagir = new veritabani();
                dtgFirmaTablo.DataSource = cagir.EvrakDurumunaGöreTabloGetir("ONAYLANDI");
                this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
                btnFirmaSil.Enabled = false;
            }
            else if(cbSecim.SelectedItem.ToString()=="ONAYLANMADI")
            {
                veritabani cagir = new veritabani();
                dtgFirmaTablo.DataSource = cagir.EvrakDurumunaGöreTabloGetir("ONAYLANMADI");
                lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
                this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
                btnFirmaSil.Enabled = false;
            }
            else
            {
                veritabani cagir = new veritabani();
                dtgFirmaTablo.DataSource = cagir.FirmaTabloCek();

                lstKayitliFirmaSayi.Text = Convert.ToString(dtgFirmaTablo.RowCount);
                this.dtgFirmaTablo.Columns["firmaId"].Visible = false;
                btnFirmaSil.Enabled = false;
            }
        }




        private void btnSureBiten_Click(object sender, EventArgs e)
        {
            SüresiBitenler süresiBitenler =new SüresiBitenler();
            süresiBitenler.suresiBitenFirmaId = Convert.ToInt32(dtgFirmaTablo.CurrentRow.Cells["firmaId"].Value.ToString());
            süresiBitenler.Show();

        }
    }
}
