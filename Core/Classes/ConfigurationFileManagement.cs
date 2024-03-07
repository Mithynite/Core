using System;
using System.Configuration;
using System.Windows.Forms;

namespace Core.Classes
{
    public class ConfigurationFileManagement
    {
        
        public static void UpdateConfigurationFile(string DataSource, string Database, string Name, string Password)
        {
            DatabaseSingleton.CloseConnection();
                    try
                    {
                        
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 
                        Console.WriteLine(config.AppSettings.Settings["DataSource"].Value);
                        Console.WriteLine(config.AppSettings.Settings["Database"].Value);
                        Console.WriteLine(config.AppSettings.Settings["Name"].Value);
                        Console.WriteLine(config.AppSettings.Settings["Password"].Value);
                        /*config.AppSettings.Settings["DataSource"].Value = DataSource;
                        config.AppSettings.Settings["Database"].Value = Database;
                        config.AppSettings.Settings["Name"].Value = Name;
                        config.AppSettings.Settings["Password"].Value = Password;
                        config.Save(ConfigurationSaveMode.Modified);*/

                        ConfigurationManager.RefreshSection("appSettings");

                        Console.WriteLine("Configuration file updated successfully.");
                    }
                    catch (ConfigurationErrorsException ex)
                    {
                        Console.WriteLine($"Error updating configuration file: {ex.Message}");
                    }
                
            }

        }
        
    }
