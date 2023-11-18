using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace adoproject
{
    public class db
    {
        private static string baglanti= "Data Source=.;Initial Catalog=bakkal;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(baglanti);
        public static SqlCommand cmd = new SqlCommand("",con);
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        public static string sql;

        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {

                 HttpContext.Current.Response.Write(ex.Message);
            }
        }
        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write(ex.Message);
            }
        }
    }
}