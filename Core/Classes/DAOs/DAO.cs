using System;
using System.Data.SqlClient;

namespace Core.Classes.DAOs
{
    public class DAO
    {
        
        /*
         * Třída DAO jepouze základem pro ostatní třídy s touto příponou, všechny musí obsahovat nějaké připojení
         * do SQL, takže jsou odděděny od tohoto rodiče.
         */
        
        protected SqlConnection _connection;

        public DAO()
        {
            try
            {
                _connection = DatabaseSingleton.GetInstance();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an Error while connecting to database: {ex}");
            }
        }
    }
}