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
    public partial class FirmaUrunBilgi : Form
    {
        public FirmaUrunBilgi()
        {
            InitializeComponent();
        }

  
        

        public int urunBilgiFirmaId = 0, butonD=0;
        public string urunBilgiFirmaAd;



        public void TabloCek()
        {
            veritabani cagir = new veritabani();
            lstFirmaAd.Text = urunBilgiFirmaAd;
            dtgUrunTablo.DataSource = cagir.FirmaUrunTabloCek(urunBilgiFirmaId);
            this.dtgUrunTablo.Columns["urunId"].Visible = false;
            this.dtgUrunTablo.Columns["firmaId"].Visible = false;
            dtgUrunTablo.RowHeadersVisible = false;
        }




        public void  ToplamSatisAdeti()
        {
            int sayi = 0;

            for (int i = 0; i < dtgUrunTablo.Rows.Count; i++)//DataGridView'ımızın satır sayısı kadar döngümüzün çalışmasını istiyoruz.
            {
                if (!string.IsNullOrEmpty(dtgUrunTablo.Rows[i].Cells[2].Value.ToString()))
                {
                    sayi++;
                }
            }
            lstToplamSatisAdet.Text = sayi.ToString();
        }



        public void SonTarih()
        {
            veritabani cagir = new veritabani();
            lstSonSatisTarih.Text = cagir.TarihGetir(urunBilgiFirmaId);
        }





        public void ToplamTutar()
        {
            int toplam = 0;
            for (int i = 0; i < dtgUrunTablo.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dtgUrunTablo.Rows[i].Cells[4].Value);
            }
            lstToplamTutar.Text = toplam.ToString();
        }





        private void FirmaUrunBilgi_Load(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            lstFirmaAd.Text = urunBilgiFirmaAd;
            dtgUrunTablo.DataSource = cagir.FirmaUrunTabloCek(urunBilgiFirmaId);
            this.dtgUrunTablo.Columns["urunId"].Visible = false;
            this.dtgUrunTablo.Columns["firmaId"].Visible = false;
            dtgUrunTablo.RowHeadersVisible = false;
            btnUrunDuzen.Enabled = false;
            btnUrunSil.Enabled = false;

            ToplamSatisAdeti();
            ToplamTutar();
            SonTarih();
        }





        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            butonD = 1;          
            UrunEkle urunEkleSayfa = new UrunEkle();            
            urunEkleSayfa.urunButonDurum = butonD;
            urunEkleSayfa.urunEklefirmaId = urunBilgiFirmaId;          
            urunEkleSayfa.Show();
        }



        private void btnUrunSil_Click(object sender, EventArgs e)
        {          
            DialogResult secenek = MessageBox.Show("Ürün kaydını silmek istediğinizden emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                veritabani cagir = new veritabani();
                cagir.UrunSil(dtgUrunTablo.CurrentRow.Cells["urunId"].Value.ToString());

                dtgUrunTablo.DataSource = cagir.FirmaUrunTabloCek(urunBilgiFirmaId);
                this.dtgUrunTablo.Columns["urunId"].Visible = false;
                this.dtgUrunTablo.Columns["firmaId"].Visible = false;
                dtgUrunTablo.RowHeadersVisible = false;
            }
            else if (secenek == DialogResult.No)
            {
            }
        }



        private void dtgUrunTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgUrunTablo.SelectedCells[0].RowIndex;
            lstBasSure.Text = dtgUrunTablo.Rows[secilen].Cells[3].Value.ToString();
            btnUrunDuzen.Enabled = true;
            btnUrunSil.Enabled = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUrunDuzen_Click(object sender, EventArgs e)
        {
            butonD = 0;
            UrunEkle urunEkleSayfa = new UrunEkle();
            urunEkleSayfa.urunButonDurum = butonD;
            urunEkleSayfa.ekleUrunId = Convert.ToInt32(dtgUrunTablo.CurrentRow.Cells["urunId"].Value.ToString());
            urunEkleSayfa.urunEklefirmaId = Convert.ToInt32(dtgUrunTablo.CurrentRow.Cells["firmaId"].Value.ToString());
            urunEkleSayfa.satisT = dtgUrunTablo.CurrentRow.Cells["satisTarih"].Value.ToString();
            urunEkleSayfa.kayitT = dtgUrunTablo.CurrentRow.Cells["kayitTarih"].Value.ToString();
            urunEkleSayfa.tutr = Convert.ToInt32(dtgUrunTablo.CurrentRow.Cells["tutar"].Value.ToString());
            urunEkleSayfa.komisyonT = Convert.ToInt32(dtgUrunTablo.CurrentRow.Cells["komisyonTutar"].Value.ToString());
            urunEkleSayfa.progT = dtgUrunTablo.CurrentRow.Cells["programTip"].Value.ToString();
            urunEkleSayfa.ack = dtgUrunTablo.CurrentRow.Cells["aciklama"].Value.ToString();           
            urunEkleSayfa.Show();           
        }
    }
}
