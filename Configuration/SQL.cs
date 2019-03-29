using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Configuration
{
    class SQL
    {
        string connectionString;

        public SQL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        internal void TestConnection()
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                string query = "SELECT * FROM [Fog_Light_Kanban].[dbo].[Configuration_Table]";
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = db;
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetData(string Key)
        {
            string value = string.Empty;

            // Use the string to get the value
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                string query = "SELECT [Value] FROM [Fog_Light_Kanban].[dbo].[Configuration_Table] WHERE [Key] = '" + Key + "'";
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = db;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader[0].ToString();
                    }
                }
            }
            return value;
        }

        public int StoreData(string Key, string Value)
        {
            int rowsChanged = 0;
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                string query = "DELETE FROM [Fog_Light_Kanban].[dbo].[Configuration_Table] WHERE [Key] = '" + Key + "'";
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = db;
                    rowsChanged = command.ExecuteNonQuery();
                }
                query = "INSERT INTO [Fog_Light_Kanban].[dbo].[Configuration_Table] " +
                    "(Configuration_Table.[Key], Configuration_Table.[Value]) " +
                    "VALUES ('"+Key+"', '"+Value+"')";
                //"VALUES (" + Key + ", '" + Value + "')";
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = db;
                    rowsChanged += command.ExecuteNonQuery();
                }
            }
            return rowsChanged;
        }

        public void CreateConfigTable()
        {
            string scriptLocation = ConfigurationManager.AppSettings["ConfigurationTableScript"].ToString();
            string script = File.ReadAllText(scriptLocation);


            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, db))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            //using (SqlConnection db = new SqlConnection(connectionString))
            //{
            //    db.Open();
            //    using (SqlCommand command = new SqlCommand(script))
            //    { 
            //        {
            //            command.Connection = db;
            //            command.ExecuteNonQuery();
            //            command.ConnectionContext.ExecuteNonQuery();
            //        }

            //    }
            //}
        }
    }
}
