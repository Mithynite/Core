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
        
        /*
         * Tato třída slouží jako Singleton pro připojení do databáze,
         * zakládá SQL connection.
         * Jakákoli podobnost s školním předlohou je víceméně náhodná. 
         */
        
        private static SqlConnection connection;

        private DatabaseSingleton()
        {
        }

        public static SqlConnection GetInstance() // Metoda, která načte data z konfiguračního souboru a vytvoří z nich SqlConnectionStringBuilder, který se využije pro připojení do vzdálené databáze
        {
            if (connection == null)
            {
                SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder()
                {
                    UserID = ReadSetting("Name"),
                    Password = ReadSetting("Password"),
                    InitialCatalog = ReadSetting("Database"),
                    DataSource = ReadSetting("DataSource"),
                    ConnectTimeout = 30
                };
                connection = new SqlConnection(connStringBuilder.ConnectionString);
                connection.Open();

            }
            return connection;
                
        }

        public static void CloseConnection() // Ukončení spojení s databází
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private static string ReadSetting(string key) // Přečtení dat z App.config
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }
    }
}
