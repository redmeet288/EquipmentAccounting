using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace EA_DAL.BaseGetConnect
{
    public static class Connect
    {
        private static string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return @"Data Source=localhost\SQLEXPRESS;
            Initial Catalog=All_db_for_IT;
            Integrated Security=True;
            TrustServerCertificate=True";
        }


        public static int ExecuteSql(string sql)
        {
            using (var connection = new SqlConnection(GetConnectionString()))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (sql.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                {
                    command.ExecuteReader().Close();
                    return -1;
                }
                else
                {
                    return command.ExecuteNonQuery();
                }
            }
        }


        public static DataTable ExecuteSelect(string selectSql)
        {
            DataTable resultTable = new DataTable();

            using (var connection = new SqlConnection(GetConnectionString()))
            using (var command = new SqlCommand(selectSql, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    resultTable.Load(reader);
                }
            }

            return resultTable;
        }
    }
}
