using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    public class DatabaseSingleton
    {
        private static SqlConnection connection;

        private DatabaseSingleton()
        {
        }

        public static SqlConnection GetInstance()
        {
            if (connection == null)
            {
                SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
                connStringBuilder.UserID = ReadSetting("Name");
                connStringBuilder.Password = ReadSetting("Password");
                connStringBuilder.InitialCatalog = ReadSetting("Database");
                connStringBuilder.DataSource = ReadSetting("DataSource");
                connStringBuilder.ConnectTimeout = 30;
                connection = new SqlConnection(connStringBuilder.ConnectionString);
                connection.Open();

            }
            return connection;
                
        }

        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private static string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found"; //TODO pokud je první null, vrátí se druhý
            return result;
        }
    }
}
