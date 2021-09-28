using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectWF
{
    class DataAccess
    {
        public static string ConnStr = @"server=DESKTOP-MCQ0EH5\SQLEXPRESS;database=clDB;integrated security=True";


        public static int InsertUPdateDelete(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(ConnStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                rows = cmd.ExecuteNonQuery();//Insert-update-delete
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }
        public static object GetSingleValue(string sql)
        {
            object obj = null;

            SqlConnection conn = new SqlConnection(ConnStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }
        public static DataTable GetManyRowsColumns(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
