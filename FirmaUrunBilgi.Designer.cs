
namespace bayipanel
{
    partial class FirmaUrunBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaUrunBilgi));
            this.lstFirmaAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstToplamSatisAdet = new System.Windows.Forms.Label();
            this.dtgUrunTablo = new System.Windows.Forms.DataGridView();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komisyonTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lstSonSatisTarih = new System.Windows.Forms.Label();
            this.btnUrunDuzen = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lstToplamTutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBasSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUrunTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFirmaAd
            // 
            this.lstFirmaAd.AutoSize = true;
            this.lstFirmaAd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstFirmaAd.Location = new System.Drawing.Point(73, 15);
            this.lstFirmaAd.Name = "lstFirmaAd";
            this.lstFirmaAd.Size = new System.Drawing.Size(0, 16);
            this.lstFirmaAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma  :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lstToplamSatisAdet);
            this.panel2.Controls.Add(this.dtgUrunTablo);
            this.panel2.Controls.Add(this.btnUrunSil);
            this.panel2.Controls.Add(this.lstSonSatisTarih);
            this.panel2.Controls.Add(this.btnUrunDuzen);
            this.panel2.Controls.Add(this.btnUrunEkle);
            this.panel2.Controls.Add(this.lstToplamTutar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lstBasSure);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(7, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 426);
            this.panel2.TabIndex = 1;
            // 
            // lstToplamSatisAdet
            // 
            this.lstToplamSatisAdet.AutoSize = true;
            this.lstToplamSatisAdet.Location = new System.Drawing.Point(793, 377);
            this.lstToplamSatisAdet.Name = "lstToplamSatisAdet";
            this.lstToplamSatisAdet.Size = new System.Drawing.Size(0, 13);
            this.lstToplamSatisAdet.TabIndex = 10;
            // 
            // dtgUrunTablo
            // 
            this.dtgUrunTablo.AllowUserToAddRows = false;
            this.dtgUrunTablo.AllowUserToDeleteRows = false;
            this.dtgUrunTablo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUrunTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUrunTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUrunTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.firmaId,
            this.satisTarih,
            this.kayitTarih,
            this.tutar,
            this.komisyonTutar,
            this.programTip,
            this.tarih,
            this.aciklama});
            this.dtgUrunTablo.Location = new System.Drawing.Point(6, 9);
            this.dtgUrunTablo.Name = "dtgUrunTablo";
            this.dtgUrunTablo.ReadOnly = true;
            this.dtgUrunTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUrunTablo.Size = new System.Drawing.Size(935, 308);
            this.dtgUrunTablo.TabIndex = 4;
            this.dtgUrunTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUrunTablo_CellClick);
            // 
            // urunId
            // 
            this.urunId.DataPropertyName = "urunId";
            this.urunId.HeaderText = "Urun Id";
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            // 
            // firmaId
            // 
            this.firmaId.DataPropertyName = "firmaId";
            this.firmaId.HeaderText = "Firma Id";
            this.firmaId.Name = "firmaId";
            this.firmaId.ReadOnly = true;
            // 
            // satisTarih
            // 
            this.satisTarih.DataPropertyName = "satisTarih";
            this.satisTarih.HeaderText = "Satış Tarihi";
            this.satisTarih.Name = "satisTarih";
            this.satisTarih.ReadOnly = true;
            // 
            // kayitTarih
            // 
            this.kayitTarih.DataPropertyName = "kayitTarih";
            this.kayitTarih.HeaderText = "Kayıt Tarihi";
            this.kayitTarih.Name = "kayitTarih";
            this.kayitTarih.ReadOnly = true;
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "tutar";
            this.tutar.HeaderText = "Tutar";
            this.tutar.Name = "tutar";
            this.tutar.ReadOnly = true;
            // 
            // komisyonTutar
            // 
            this.komisyonTutar.DataPropertyName = "komisyonTutar";
            this.komisyonTutar.HeaderText = "Komisyon Tutarı";
            this.komisyonTutar.Name = "komisyonTutar";
            this.komisyonTutar.ReadOnly = true;
            // 
            // programTip
            // 
            this.programTip.DataPropertyName = "programTip";
            this.programTip.HeaderText = "Program Tipi";
            this.programTip.Name = "programTip";
            this.programTip.ReadOnly = true;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.BackgroundImage")));
            this.btnUrunSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunSil.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunSil.FlatAppearance.BorderSize = 0;
            this.btnUrunSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(208, 332);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(100, 40);
            this.btnUrunSil.TabIndex = 3;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lstSonSatisTarih
            // 
            this.lstSonSatisTarih.AutoSize = true;
            this.lstSonSatisTarih.Location = new System.Drawing.Point(794, 353);
            this.lstSonSatisTarih.Name = "lstSonSatisTarih";
            this.lstSonSatisTarih.Size = new System.Drawing.Size(0, 13);
            this.lstSonSatisTarih.TabIndex = 9;
            // 
            // btnUrunDuzen
            // 
            this.btnUrunDuzen.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunDuzen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunDuzen.BackgroundImage")));
            this.btnUrunDuzen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunDuzen.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunDuzen.FlatAppearance.BorderSize = 0;
            this.btnUrunDuzen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunDuzen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunDuzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunDuzen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunDuzen.Location = new System.Drawing.Point(107, 332);
            this.btnUrunDuzen.Name = "btnUrunDuzen";
            this.btnUrunDuzen.Size = new System.Drawing.Size(100, 40);
            this.btnUrunDuzen.TabIndex = 2;
            this.btnUrunDuzen.Text = "Ürün Düzenle";
            this.btnUrunDuzen.UseVisualStyleBackColor = false;
            this.btnUrunDuzen.Click += new System.EventHandler(this.btnUrunDuzen_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.BackgroundImage")));
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunEkle.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(5, 332);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 40);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lstToplamTutar
            // 
            this.lstToplamTutar.AutoSize = true;
            this.lstToplamTutar.Location = new System.Drawing.Point(793, 395);
            this.lstToplamTutar.Name = "lstToplamTutar";
            this.lstToplamTutar.Size = new System.Drawing.Size(0, 13);
            this.lstToplamTutar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(643, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Son yapılan satış tarih   :";
            // 
            // lstBasSure
            // 
            this.lstBasSure.AutoSize = true;
            this.lstBasSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstBasSure.Location = new System.Drawing.Point(794, 333);
            this.lstBasSure.Name = "lstBasSure";
            this.lstBasSure.Size = new System.Drawing.Size(0, 13);
            this.lstBasSure.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(645, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sistem kayıt tarihi          :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(645, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toplam tutar                    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(644, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yapılan satış adet           :";
            // 
            // FirmaUrunBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 483);
            this.Controls.Add(this.lstFirmaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirmaUrunBilgi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilsoft Bayi Panel Ürün Bilgiler";
            this.Load += new System.EventHandler(this.FirmaUrunBilgi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUrunTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lstFirmaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunDuzen;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lstBasSure;
        private System.Windows.Forms.DataGridView dtgUrunTablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn komisyonTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn programTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lstToplamSatisAdet;
        private System.Windows.Forms.Label lstSonSatisTarih;
        private System.Windows.Forms.Label lstToplamTutar;
    }
}