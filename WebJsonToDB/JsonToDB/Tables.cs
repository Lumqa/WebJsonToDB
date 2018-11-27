using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WebJsonToDB
{
    public class Tables
    {
        static private string connectionString = "Server=(localdb)\\mssqllocaldb;Database=JsonDB;Trusted_Connection=True;";

        static public List<dynamic> GetTables()
        {
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'JsonDB'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<dynamic> list = new List<dynamic>();
                list = connection.Query<dynamic>(sql).ToList();
                
                return list;
            }
        }

        static public List<string> GetColumsName(string table)
        {
            string sql = "SELECT COLUMN_NAME FROM JsonDB.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + table + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> list = new List<string>();
                list = connection.Query<string>(sql).ToList();

                return list;
            }
        }

        static public List<dynamic> GetAllRows(string table)
        {
            string sql = "SELECT * FROM " + table;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<dynamic> list = new List<dynamic>();
                list = connection.Query<dynamic>(sql).ToList();
                
                return list;
            }
        }

        static public List<dynamic> GetRow(dynamic id, string table, string fColumn)
        {
            string sql = "SELECT * FROM " + table + " WHERE " + fColumn + "='" + id + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<dynamic> list = new List<dynamic>();
                list = connection.Query<dynamic>(sql).ToList();

                return list;
            }
        }

        static public string Delete(dynamic id, string table, string fColumn)
        {
            string sql = "DELETE FROM " + table + " WHERE " + fColumn + "='" + id + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            return sql;
        }

        static public string Update(dynamic id, string table, string fColumn, string[] par)
        {
            string[] param = par;
            StringBuilder sb = new StringBuilder();
            List<string> columnNames = GetColumsName(table);

            sb.Append(" SET ");
            for (int i = 0; i < columnNames.Count; i++)
            {
                for (int j = 0; j < param[i].Length; j++)
                {
                    char[] charStr = param[i].ToCharArray();
                    if (charStr[j] == ',')
                    {
                        charStr[j] = '.';
                        param[i] = new string(charStr);
                        break;
                    }
                }

                sb.Append(columnNames[i]);
                sb.Append(" = ");
                if (!IsDigitsOnly(param[i]))
                {
                    sb.Append("'");
                    sb.Append(param[i]);
                    sb.Append("'");
                }
                else
                {
                    sb.Append(param[i]);
                }
                sb.Append(",");
            }
            sb.Remove(sb.Length - 1, 1);

            string sql = "UPDATE " + table
                + sb.ToString()
                + " WHERE " + fColumn + "='" + id + "'";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            return sql;
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
