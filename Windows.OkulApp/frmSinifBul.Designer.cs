namespace Windows.OkulApp
{
    partial class frmSinifBul
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
            this.txt_sinifad = new System.Windows.Forms.TextBox();
            this.btn_bul = new System.Windows.Forms.Button();
            this.grpbox_bul = new System.Windows.Forms.GroupBox();
            this.grpbox_bul.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sinifad
            // 
            this.txt_sinifad.Location = new System.Drawing.Point(25, 31);
            this.txt_sinifad.Name = "txt_sinifad";
            this.txt_sinifad.Size = new System.Drawing.Size(100, 20);
            this.txt_sinifad.TabIndex = 0;
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(25, 79);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(75, 23);
            this.btn_bul.TabIndex = 1;
            this.btn_bul.Text = "BUL";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // grpbox_bul
            // 
            this.grpbox_bul.Controls.Add(this.txt_sinifad);
            this.grpbox_bul.Controls.Add(this.btn_bul);
            this.grpbox_bul.Location = new System.Drawing.Point(23, 28);
            this.grpbox_bul.Name = "grpbox_bul";
            this.grpbox_bul.Size = new System.Drawing.Size(195, 214);
            this.grpbox_bul.TabIndex = 2;
            this.grpbox_bul.TabStop = false;
            this.grpbox_bul.Text = "Sınıflar";
            // 
            // frmSinifBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.grpbox_bul);
            this.Name = "frmSinifBul";
            this.Text = "frmSinifBul";
            this.grpbox_bul.ResumeLayout(false);
            this.grpbox_bul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sinifad;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.GroupBox grpbox_bul;
    }
}