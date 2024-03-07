using System;
using System.Data.SqlClient;

namespace Core.Classes
{
    public class InsertIntoDatabaseDAO
    {
        private SqlConnection _connection;

        public InsertIntoDatabaseDAO()
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
        
        public void InsertNewOrder()
        {
            
        }
    }
}