using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    static class DataAccess
    {
        public static string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Ashek1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        public static bool ExecuteQuery(string query)
        {
            try
            {
                var con = new SqlConnection(conString);
                con.Open();

                var cmd = new SqlCommand(query, con);

                var result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public static bool ExecuteQuery(String query)
        //{
        //    try
        //    {

        //        var con = new SqlConnection(conString);
        //        con.Open();

        //        var cmd = new SqlCommand(query, con);

        //        var result = cmd.ExecuteNonQuery();
        //        //SqlConnection con = new SqlConnection();
        //        //public static string _connectionString = "Data Source=.;Initial Catalog=EventDb;Integrated Security=True;Encrypt=False";
        //        con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False";
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = con;
        //        cmd.CommandText = query;
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return false;
        //    }
        //}
        public static DataTable GetData(String query)
        {
            try
            {
                //conString = "Data Source=.;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False";
                var con = new SqlConnection(conString);
                conString = @"Data Source=.\SQLEXPRESS;
  Initial Catalog=Ashek1;
  Integrated Security=True;
  Encrypt=False;
  TrustServerCertificate=True;";
                con.Open();

                var cmd = new SqlCommand(query, con);
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True";
                //con.Open();

                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;
                //cmd.CommandText = query;///select id, full name---> 2 col data only

                SqlDataAdapter adp = new SqlDataAdapter(cmd);///convertion
                DataSet ds = new DataSet();///sql data set
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
