using DAL;
using DosyaIslemleriLib;
using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.BLL //BusinessLogicLayer
{
    public class SinifBL
    {
        static readonly SinifBL instance = new SinifBL();//Singleton
        Helper hlp = Helper.Instance; 

        public static SinifBL Instance
        {
            get
            {
                return instance;
            }
        }

        SinifBL()
        {

        }
        #region Ekleme İşlemi
        public bool Insert(SinifModel s)
        {

            
            DosyaIslem ds = new DosyaIslem();
            try
            {
               
                SqlParameter[] p = { new SqlParameter("@SinifAd", s.Sinifad), new SqlParameter("@Kontenjan", s.Kontenjan) };
                return hlp.ExecuteNonQuery("Insert into tblSiniflar(SinifAd,Kontenjan)values(@SinifAd,@Kontenjan)", p) > 0;

            }
            catch (SqlException ex)
            {
                ds.DosyaKaydet("Hatamesajları.txt", "Hata mesajı :" + ex.Message + "\r\nTarih :" + DateTime.Now + "\r\nHata Numarası :" + ex.Number);
                throw ex;

            }
            catch (Exception ex)
            {
                ds.DosyaKaydet("Hatamesajları.txt", "Hata mesajı :" + ex.Message + "\r\nTarih :" + DateTime.Now + "\r\nHata Numarası :" + ex.StackTrace); //Exception class'ında number yok Stack trace hata tespitinde kullanılır
                throw ex;

            }
        }
        #endregion
        #region Güncelleme İşlemi
        public bool Update(SinifModel s)
        {
            
            DosyaIslem ds = new DosyaIslem();
            try
            {
                
                SqlParameter[] p = { new SqlParameter("@SinifAd", s.Sinifad), new SqlParameter
                    ("@Kontenjan", s.Kontenjan), new SqlParameter("@SinifId",s.Sinifid) };
                return hlp.ExecuteNonQuery("Update tblSiniflar set Kontenjan=@Kontenjan,SinifAd=@SinifAd where SinifId=@SinifId", p) > 0;

            }
            catch (SqlException ex)
            {
                ds.DosyaKaydet("Hatamesajları.txt", "Hata mesajı :" + ex.Message + "\r\nTarih :" + DateTime.Now + "\r\nHata Numarası :" + ex.Number);

                throw ex;


            }
            catch (Exception ex)
            {
                ds.DosyaKaydet("Hatamesajları.txt", "Hata mesajı :" + ex.Message + "\r\nTarih :" + DateTime.Now + "\r\nHata Numarası :" + ex.StackTrace); //Exception class'ında number yok Stack trace hata tespitinde kullanılır
                throw ex;

            }

        }
        #endregion
        #region Silme İşlemi
        public bool Sil(int sinifid)
        {
        
            try
            {
                
                SqlParameter[] p = { new SqlParameter("@sinifid", sinifid)};
                return hlp.ExecuteNonQuery("Delete From tblSiniflar where SinifId=@sinifid",  p) > 0 ;

            }
            catch (SqlException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        #endregion



        #region SinifBulmaİslemi
        public SinifModel SinifBul(string sinifad)

        {
            try
            {
                SinifModel sm = null;
                SqlParameter[] p = { new SqlParameter("@SinifAd", sinifad) };
                SqlDataReader dr = hlp.ExecuteReader("Select SinifAd,Kontenjan,SinifId from tblSiniflar where Sinifad=@SinifAd", p);
                if (dr.Read())
                {
                    sm = new SinifModel { Kontenjan = Convert.ToInt32(dr["Kontenjan"]), Sinifad = dr["SinifAd"].ToString(), Sinifid = Convert.ToInt32(dr["SinifId"]) };
                }
                dr.Close();
                return sm;
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            catch (Exception ex)
            {

                throw ex;
            }



        } 
        #endregion

        public List<SinifModel> SinifListesiGetir()
        {
            List<SinifModel> lst = null;
            SqlDataReader dr=hlp.ExecuteReader("Select * from tblSiniflar",null);
            if(dr.HasRows)
            {
                lst = new List<SinifModel>();
                while(dr.Read())
                {
                    lst.Add(new SinifModel { Kontenjan = Convert.ToInt32(dr["Kontenjan"]), Sinifad = dr["SinifAd"].ToString(), Sinifid = Convert.ToInt32(dr["SinifId"]) });
                }
                dr.Close();
            }
            return lst;
        }

        public DataTable SinifTablosuGetir()
        {
            return hlp.GetDataTable("Select SinifAd,SinifId from tblSiniflar", null);
        }
    }
}
