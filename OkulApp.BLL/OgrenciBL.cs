using DAL;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public Helper hlp = Helper.Instance;
        static readonly OgrenciBL instance = new OgrenciBL();

        public static OgrenciBL Instance
        {
            get
            {
                return instance;
            }
        }

         OgrenciBL()
        {

        }
        public bool OgrenciEkle(OgrenciModel o)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", o.Ad),
                    new SqlParameter("@Soyad", o.Soyad),
                    new SqlParameter("@Numara", o.Numara),
                    new SqlParameter("@Telno", o.TelNo),
                    new SqlParameter("@Sinifid", o.Sinifid) };
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values (@Ad,@Soyad,@Numara,@Telno,@Sinifid)", p) > 0;

            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool OgrenciGuncelle(OgrenciModel o)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", o.Ad),
                    new SqlParameter("@Soyad", o.Soyad),
                    new SqlParameter("@Numara", o.Numara),
                    new SqlParameter("@Telno", o.TelNo),
                    new SqlParameter("@Sinifid", o.Sinifid) };
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara,TelNo=@Telno", p) > 0;

            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable OgrenciTablosu()
        {
            return hlp.GetDataTable("SELECT tblOgrenciler.Ad, tblOgrenciler.Soyad, tblOgrenciler.Numara, tblOgrenciler.TelNo, tblSiniflar.SinifAd FROM tblOgrenciler INNER JOIN tblSiniflar ON tblOgrenciler.SınıfId = tblSiniflar.SinifId", null);
        }
    }
}
