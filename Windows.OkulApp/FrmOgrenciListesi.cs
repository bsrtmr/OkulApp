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

namespace Windows.OkulApp
{
    public partial class FrmOgrenciListesi : Form
    {
        DataTable dt = null;
        OgrenciBL ob = OgrenciBL.Instance;
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }



        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            Grid_ogrenci.AutoGenerateColumns = false;
            dt = ob.OgrenciTablosu();
            Grid_ogrenci.DataSource = dt;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dt.Rows)
            {
                switch (item.RowState)
                {
                    case DataRowState.Detached:
                        break;
                    case DataRowState.Unchanged:
                        break;
                    case DataRowState.Added:
                        break;
                    case DataRowState.Deleted:
                        break;
                    case DataRowState.Modified:
                        ob.OgrenciGuncelle(new OgrenciModel {Ad=item[0].ToString(),Soyad=item[1].ToString(),Numara=item[2].ToString(),TelNo=item[3].ToString() });
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
