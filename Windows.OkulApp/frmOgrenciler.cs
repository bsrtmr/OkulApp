using OkulApp.BLL;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;

namespace Windows.OkulApp
{
    public partial class frmOgrenciler : Form
    {
        static readonly frmOgrenciler instance = new frmOgrenciler();

        public static frmOgrenciler Instance
        {
            get
            {
                return instance;
            }
        }

        public frmOgrenciler()
        {
            InitializeComponent();
        }

        void SinifListesiYukle()
        {
            SinifBL sb = SinifBL.Instance;
            cmbSiniflar.DisplayMember = "Sinifad"; //Listedeki hangi elemanın görünmesini istiyorsak
            cmbSiniflar.ValueMember = "Sinifid"; //Kullanıcının görmesi gerekmeyen arka planda tutulması için
            //List<SinifModel> lst = sb.SinifListesiGetir();
            //lst.Insert(0, new SinifModel { Sinifad="Seçiniz" ,Sinifid=0});
            //cmbSiniflar.DataSource = lst;
            cmbSiniflar.DataSource = sb.SinifTablosuGetir();
            cmbSiniflar.Text = "Seçiniz";
        }

        private void frmOgrenciler_Load(object sender, EventArgs e)
        {
            SinifListesiYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbSiniflar.SelectedValue.ToString()=="0")
            {
                MessageBox.Show("Sinif Seciniz!");
                return;

            }
            OgrenciModel o = new OgrenciModel { Ad = txt_Ad.Text.Trim(), Numara = txt_Numara.Text.Trim(), Soyad = txt_Soyad.Text.Trim(), TelNo = txt_TelNo.Text.Trim(), Sinifid = Convert.ToInt32(cmbSiniflar.SelectedValue) };
            OgrenciBL ob = OgrenciBL.Instance;
            ob.OgrenciEkle(o);
        }

        public static frmOgrenciler GetInstance()
        {
            frmOgrenciler frm = (frmOgrenciler)Application.OpenForms["frmOgrenciler"];
            if(frm==null)
            {
                frm = new frmOgrenciler();
            }
            return frm;
        }

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e) //Aynı metodu soyad için yazmak yerine Event'ten KeyPress'i değiştirdik.
        {
            if((int)e.KeyChar>=48 && (int)e.KeyChar<=57)
            {
                e.Handled = true;
            }
        }
    }
}
