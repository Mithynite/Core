using System;
using System.Configuration;
using System.Windows.Forms;

namespace Core.Classes
{
    public class ConfigurationFileManagement
    {

        /*
         * Tato třída obsahuje vše, co je potřeba k úpravě konfiguračního souboru, který podává informace
         * důležité pro připojení k databázi
         */
        
        public static void UpdateConfigurationFile(string DataSource, string Database, string Name, string Password) // Metoda pro změnu konfiguračního souboru
        {
            DatabaseSingleton.CloseConnection(); // Uzavření připojení do databíze (pro jistotu)
            try
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["DataSource"].Value = DataSource;
                config.AppSettings.Settings["Database"].Value = Database;
                config.AppSettings.Settings["Name"].Value = Name;
                config.AppSettings.Settings["Password"].Value = Password;
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                Console.WriteLine("Configuration file updated successfully.");
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine($"Error while updating configuration file: {ex.Message}");

            }

        }

    }
}
