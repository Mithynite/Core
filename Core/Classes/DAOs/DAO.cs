using System;
using System.Data.SqlClient;

namespace Core.Classes.DAOs
{
    public class DAO
    {
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

        public bool CanBeParsedToInt(string val)
        {
            int number;
            return int.TryParse(val, out number);
        }
        
    }
}