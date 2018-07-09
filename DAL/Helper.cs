using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn = null;
        static readonly Helper instance = new Helper(); //Böylece sürekli yeni nesne oluşturmadan diğer class'lardan Helper'ı çağırabileceğiz (*) Singleton Design Pattern


        public static Helper Instance
        {
            get
            {
                return instance;
            }
        }

         Helper() //constructor private olduğu için yeni nesne oluşamaz
        {
           

        }

        public int ExecuteNonQuery(string cmdtext,SqlParameter[] p)
        {
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString)) //bellegi temizliyor cn kapatıyor
                {
                    using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                             OpenConnection();
                            int sonuc = cmd.ExecuteNonQuery();
                            return sonuc;
                    }

                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
               // CloseConnection();
            }

        }

        void OpenConnection()
        {
            if (cn != null && cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        void CloseConnection()
        {
            if(cn!=null && cn.State!=ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                OpenConnection();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); 
                }
                    
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

        public DataTable GetDataTable(string cmdtext,SqlParameter[]p)
        {
            try
          {
               using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            if (p!=null)
            {
                da.SelectCommand.Parameters.AddRange(p);
            }
            DataTable dt = new DataTable(); //içini veri ile dolduracağımız boş data table
            da.Fill(dt); //dataadapterın fill metodu sorgu sonucunda dönen veriyi datatable'a atar
            return dt;

            }
          }
            catch (Exception ex)
            {

                throw ex;
            }
            

           
        }


    }
    }
