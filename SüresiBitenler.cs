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
    public partial class SüresiBitenler : Form
    {
        public SüresiBitenler()
        {
            InitializeComponent();
        }

        public int suresiBitenFirmaId;
        string tarihDeger;


        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();
            tarihDeger = dtpTarih.Value.ToString();
            dtgTablo.DataSource = cagir.SuresiBiten(suresiBitenFirmaId,tarihDeger);
            this.dtgTablo.Columns["firmaId"].Visible = false;
            dtgTablo.RowHeadersVisible = false;
        }




        private void SüresiBitenler_Load(object sender, EventArgs e)
        {
            veritabani cagir = new veritabani();  
            dtgTablo.DataSource = cagir.FirmaUrunTabloCek(suresiBitenFirmaId);
            this.dtgTablo.Columns["urunId"].Visible = false;
            this.dtgTablo.Columns["firmaId"].Visible = false;
            dtgTablo.RowHeadersVisible = false;
        }
    }
}
