namespace Windows.OkulApp
{
    partial class FrmOgrenciListesi
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
            this.Grid_ogrenci = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinifAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ogrenci
            // 
            this.Grid_ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ogrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.Numara,
            this.Telno,
            this.SinifAd});
            this.Grid_ogrenci.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid_ogrenci.Location = new System.Drawing.Point(0, 0);
            this.Grid_ogrenci.Name = "Grid_ogrenci";
            this.Grid_ogrenci.Size = new System.Drawing.Size(514, 238);
            this.Grid_ogrenci.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(190, 285);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 41);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Adı";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyadı";
            this.Soyad.Name = "Soyad";
            // 
            // Numara
            // 
            this.Numara.DataPropertyName = "Numara";
            this.Numara.HeaderText = "Numarası";
            this.Numara.Name = "Numara";
            // 
            // Telno
            // 
            this.Telno.DataPropertyName = "TelNo";
            this.Telno.HeaderText = "Tel No";
            this.Telno.Name = "Telno";
            // 
            // SinifAd
            // 
            this.SinifAd.DataPropertyName = "SinifAd";
            this.SinifAd.HeaderText = "Sınıfı";
            this.SinifAd.Name = "SinifAd";
            this.SinifAd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 371);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.Grid_ogrenci);
            this.Name = "FrmOgrenciListesi";
            this.Text = "FrmOgrenciListesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ogrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_ogrenci;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telno;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinifAd;
    }
}