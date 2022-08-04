using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Accounting01
{
    public class DatabaseAccess
    {
        public static SqlConnection conn;

        private static SqlConnection ConnOpen()
        {
            if (conn == null) 
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-C3S1HBD9\SQLEXPRESS;Initial Catalog=Acounting01;Integrated Security=True");
            }

            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            return conn;
        }

        public static bool Insert(string query)
        {
            try
            {
                int numofrow = 0;
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                numofrow = cmd.ExecuteNonQuery();
                if (numofrow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {

                return false;
            }
        }

        public static bool Update(string query)
        {
            try
            {
                int numofrow = 0;
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                numofrow = cmd.ExecuteNonQuery();
                if (numofrow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {

                return false;
            }
        }

        public static bool Delete(string query)
        {
            try
            {
                int numofrow = 0;
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                numofrow = cmd.ExecuteNonQuery();
                if (numofrow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {

                return false;
            }
        }

        public static DataTable Retrieve(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnOpen());
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
