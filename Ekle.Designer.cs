
namespace bayipanel
{
    partial class Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekle));
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtVergiDaire = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFaaliyet = new System.Windows.Forms.TextBox();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.txtYetkiliTel = new System.Windows.Forms.MaskedTextBox();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYetkiliUnvan = new System.Windows.Forms.TextBox();
            this.txtYetkiliSoyad = new System.Windows.Forms.TextBox();
            this.txtYetkiliAd = new System.Windows.Forms.TextBox();
            this.btnFirmaDuzen = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(158, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 20);
            this.txtMail.TabIndex = 13;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(158, 174);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiNo.Location = new System.Drawing.Point(158, 225);
            this.txtVergiNo.MaxLength = 12;
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(222, 23);
            this.txtVergiNo.TabIndex = 16;
            this.txtVergiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVergiNo_KeyPress);
            // 
            // txtVergiDaire
            // 
            this.txtVergiDaire.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiDaire.Location = new System.Drawing.Point(158, 198);
            this.txtVergiDaire.Name = "txtVergiDaire";
            this.txtVergiDaire.Size = new System.Drawing.Size(222, 23);
            this.txtVergiDaire.TabIndex = 15;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(158, 72);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(222, 60);
            this.txtAdres.TabIndex = 12;
            // 
            // txtFaaliyet
            // 
            this.txtFaaliyet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaaliyet.Location = new System.Drawing.Point(158, 45);
            this.txtFaaliyet.Name = "txtFaaliyet";
            this.txtFaaliyet.Size = new System.Drawing.Size(222, 23);
            this.txtFaaliyet.TabIndex = 11;
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAd.Location = new System.Drawing.Point(158, 19);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(222, 23);
            this.txtFirmaAd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Firma Vergi No            :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Firma Vergi Dairesi    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Firma Telefon              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma Mail                    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma Adres                 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma Faaliyet Alanı    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Ad                       :";
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnFirmaEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.BackgroundImage")));
            this.btnFirmaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirmaEkle.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaEkle.FlatAppearance.BorderSize = 0;
            this.btnFirmaEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.Location = new System.Drawing.Point(158, 393);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(222, 34);
            this.btnFirmaEkle.TabIndex = 23;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click_1);
            // 
            // txtYetkiliTel
            // 
            this.txtYetkiliTel.Location = new System.Drawing.Point(158, 332);
            this.txtYetkiliTel.Mask = "(999) 000-0000";
            this.txtYetkiliTel.Name = "txtYetkiliTel";
            this.txtYetkiliTel.Size = new System.Drawing.Size(222, 20);
            this.txtYetkiliTel.TabIndex = 20;
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(158, 365);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(15, 14);
            this.cbDurum.TabIndex = 21;
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Evrak Durum                :";
            // 
            // txtYetkiliUnvan
            // 
            this.txtYetkiliUnvan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliUnvan.Location = new System.Drawing.Point(158, 306);
            this.txtYetkiliUnvan.Name = "txtYetkiliUnvan";
            this.txtYetkiliUnvan.Size = new System.Drawing.Size(222, 23);
            this.txtYetkiliUnvan.TabIndex = 19;
            // 
            // txtYetkiliSoyad
            // 
            this.txtYetkiliSoyad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliSoyad.Location = new System.Drawing.Point(158, 280);
            this.txtYetkiliSoyad.Name = "txtYetkiliSoyad";
            this.txtYetkiliSoyad.Size = new System.Drawing.Size(222, 23);
            this.txtYetkiliSoyad.TabIndex = 18;
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYetkiliAd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliAd.Location = new System.Drawing.Point(158, 254);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(222, 23);
            this.txtYetkiliAd.TabIndex = 17;
            // 
            // btnFirmaDuzen
            // 
            this.btnFirmaDuzen.BackColor = System.Drawing.Color.Transparent;
            this.btnFirmaDuzen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirmaDuzen.BackgroundImage")));
            this.btnFirmaDuzen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirmaDuzen.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaDuzen.FlatAppearance.BorderSize = 0;
            this.btnFirmaDuzen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaDuzen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmaDuzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmaDuzen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaDuzen.Location = new System.Drawing.Point(158, 394);
            this.btnFirmaDuzen.Name = "btnFirmaDuzen";
            this.btnFirmaDuzen.Size = new System.Drawing.Size(222, 34);
            this.btnFirmaDuzen.TabIndex = 22;
            this.btnFirmaDuzen.Text = "Firma Düzenle";
            this.btnFirmaDuzen.UseVisualStyleBackColor = false;
            this.btnFirmaDuzen.Click += new System.EventHandler(this.btnFirmaDuzen_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(34, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Yetkili Telefon             :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Yetkili Unvan               :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(34, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Yetkili Soyad               :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yetkili Ad                      :";
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 461);
            this.Controls.Add(this.txtYetkiliTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cbDurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtYetkiliUnvan);
            this.Controls.Add(this.txtYetkiliSoyad);
            this.Controls.Add(this.txtYetkiliAd);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.btnFirmaDuzen);
            this.Controls.Add(this.txtVergiDaire);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFaaliyet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFirmaEkle);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ekle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilsoft BayiPanel Müşteri Bilgiler";
            this.Load += new System.EventHandler(this.Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFirmaDuzen;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiDaire;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFaaliyet;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.TextBox txtYetkiliUnvan;
        private System.Windows.Forms.TextBox txtYetkiliSoyad;
        private System.Windows.Forms.TextBox txtYetkiliAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtYetkiliTel;
        private System.Windows.Forms.TextBox txtMail;
    }
}