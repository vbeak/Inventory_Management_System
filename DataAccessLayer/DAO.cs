using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DAO
    {
        static string connectionStr = "";
        public static AppSettingsReader aps = new AppSettingsReader();

        static DAO()
        {
            connectionStr = aps.GetValue("myConnection",typeof(string)).ToString();
        }

        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            return con;
        
        }

        public static int IUD(string sql, SqlParameter[] param)
        {
            using (SqlConnection con = getConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        return i;
                    }
                    catch (Exception ex)
                    {
                        
                        throw ex;
                    }

                }
            }
        }

        public static DataTable getTable(string sql, SqlParameter[] param)
        {
            using (SqlConnection con = getConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
