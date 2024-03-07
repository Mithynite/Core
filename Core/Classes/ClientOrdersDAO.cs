using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Core.Classes.DAOs
{
    public class ClientOrdersDAO
    {
        private SqlConnection _connection;

        public ClientOrdersDAO()
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
        public IEnumerable<Order> GetByOrdersOfClient(string username)
        {

            using (SqlCommand command = new SqlCommand("SELECT * FROM Order_ WHERE client_id in(SELECT id FROM Client WHERE username = @username)", _connection))
                {

                command.Parameters.Add(new SqlParameter("@username", username));
                        SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order()
                        {
                            //Id = reader.GetInt32();
                            Id = Convert.ToInt32(reader[0].ToString()),
                            ClientId = Convert.ToInt32(reader[1].ToString()),
                            Number = Convert.ToInt32(reader[2].ToString()),
                            Mark = reader[3].ToString(),
                            RecordDate = Convert.ToDateTime(reader[4].ToString())
                        };
                        yield return order;
                    }

                    reader.Close();
                }
            }

        public IEnumerable<Product> GetByItemsOfAnOrder(int orderNumber)
        {
            using (SqlCommand command =
                   new SqlCommand(
                       "SELECT * FROM Product WHERE id IN (SELECT product_id FROM Order_item WHERE order_id IN (SELECT id FROM Order_ WHERE number = @orderNumber))  ",
                       _connection))
            {

                command.Parameters.Add(new SqlParameter("@orderNumber", orderNumber));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        Id = Convert.ToInt32(reader[0].ToString()),
                        CategoryId = Convert.ToInt32(reader[1].ToString()),
                        Tag = reader[2].ToString(),
                        Price = Convert.ToInt32(reader[3].ToString())
                    };
                    yield return product;
                }
                reader.Close();
            }
        }

        /*
         public string PrintExampleData()
         {
             string sql = "select * from Order_";
             using (SqlCommand command = new SqlCommand(sql, _connection))
             {

                 SqlDataReader reader = command.ExecuteReader();

                 while (reader.Read())
                 {
                     Order order = new Order()
                     {
                         Id = Convert.ToInt32(reader[0].ToString()),
                         ClientId = Convert.ToInt32(reader[1].ToString()),
                         Number = Convert.ToInt32(reader[2].ToString()),
                         Mark = reader[3].ToString(),
                         RecordDate = Convert.ToDateTime(reader[4].ToString())
                     };
                     return order.ToString();
                 }
             }

             return null;
         }
         */
    }
}
    
