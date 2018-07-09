using OkulApp.BLL;
using OkulApp.Models;
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

namespace Windows.OkulApp
{
    public partial class frmSinifBul : Form
    {
        static readonly frmSinifBul instance = new frmSinifBul();
        SinifBL sb = SinifBL.Instance;
        public frmSinifBul()
        {
            InitializeComponent();
        }

        public static frmSinifBul Instance
        {
            get
            {
                return instance;
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            try
            {
                SinifModel sm = sb.SinifBul(txt_sinifad.Text.Trim());

                if (sm != null)
                {
                    frmSiniflar frm = (frmSiniflar)Application.OpenForms["frmSiniflar"];
                    frm.txtSinifAdi.Text = sm.Sinifad;
                    frm.txtKontenjan.Text = sm.Kontenjan.ToString();
                    frm.Sinifid = sm.Sinifid;
                    frm.btn_Save.Text = "Güncelle";
                    frm.btn_Vazgec.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(txt_sinifad.Text + "Sinif Bulunamadi");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Veritabani Hatasi");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Olustu");
            }

        }
            

        }
    }
