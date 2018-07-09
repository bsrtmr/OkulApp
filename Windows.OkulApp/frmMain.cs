using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.OkulApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void öğrenciEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciler frm=frmOgrenciler.GetInstance();
            frm.MdiParent = this; //Main formu bu formun parentı
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();

        }

        private void sınıfEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiniflar frm = frmSiniflar.Instance;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(); //bu formu kapat
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
