using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DosyaIslemleriLib;
using UtilityLib;
using OkulApp.Models;
using OkulApp.BLL;

namespace Windows.OkulApp
{
    public partial class frmSiniflar : Form
    {
        private readonly static frmSiniflar instance = new frmSiniflar();

        SinifBL sb = SinifBL.Instance;
        public frmSiniflar()
        {
            InitializeComponent();
        }

        int sinifid = 0;

        public int Sinifid
        {
            get
            {
                return sinifid;
            }

            set
            {
                sinifid = value;
            }
        }

        public static frmSiniflar Instance
        {
            get
            {
                return instance;
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            frmSinifBul frm = frmSinifBul.Instance;
            frm.MdiParent = Application.OpenForms["frmMain"];
            frm.Show();
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
           DialogResult cvp= MessageBox.Show("Kayıt silinecek.Emin misiniz?","Silme Onayı",MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                try
                {
                    if (sb.Sil(sinifid))
                    {
                        MessageBox.Show("Silme işlemi başarılı!");
                        btn_Vazgec.PerformClick();
                    }

                }

                catch (SqlException ex)
                {

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Bu sınıfta okuyan öğrenciler mevcut. Sınıf silme işlemi başarısız.");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı Hatası!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Oluştu!");
                }
            }

            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi.");
            }

        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            SinifModel s = new SinifModel { Kontenjan = int.Parse(txtKontenjan.Text), Sinifad = txtSinifAdi.Text.Trim().ToUpper() };

            try
            {
                if (sinifid == 0)
                {

                    if (sb.Insert(s))
                    {
                        MessageBox.Show("Ekleme Başarılı!");
                    }
                }
                else
                {

                    if (sb.Update(s))
                    {
                        MessageBox.Show("Güncelleme Başarılı!");
                        btn_Vazgec.PerformClick();
                    }
                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (ex.Message.Contains("SinifAd"))
                    {
                        MessageBox.Show("Sınıf Adı Zaten Eklenmiş");

                    }
                 }

                else if (ex.Number==547)
                {
                    MessageBox.Show("Kontenjan 0'dan büyük olmalıdır");
                }

                else

                 {
                    MessageBox.Show("Veritabanı Hatası!");
                 }     

            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!");
            }
        }


            
        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Utility.Temizle(this.Controls);
            sinifid = 0;
            btn_Save.Text = "Ekle";
            btn_Vazgec.Visible = false;
        }





    }
}
