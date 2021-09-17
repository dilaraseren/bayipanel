
namespace bayipanel
{
    partial class SüresiBitenler
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
            this.dtgTablo = new System.Windows.Forms.DataGridView();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTablo
            // 
            this.dtgTablo.AllowUserToAddRows = false;
            this.dtgTablo.AllowUserToDeleteRows = false;
            this.dtgTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablo.Location = new System.Drawing.Point(10, 70);
            this.dtgTablo.Name = "dtgTablo";
            this.dtgTablo.ReadOnly = true;
            this.dtgTablo.Size = new System.Drawing.Size(929, 400);
            this.dtgTablo.TabIndex = 0;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(12, 32);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 1;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(212, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "\' tarihinden sonra satışı yapılmayan ürünler için arama yapılmaktadır.";
            // 
            // SüresiBitenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.dtgTablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SüresiBitenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bilsoft Bayi Panel Süresi Biten Ürünler";
            this.Load += new System.EventHandler(this.SüresiBitenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTablo;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
    }
}