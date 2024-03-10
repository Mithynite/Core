using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Core.Classes.DAOs
{
    public class SeeDataDAO : DAO
    {
        /*
         * Tato třída vypisuje data z databáze uživateli
         */
        
        public IEnumerable<Order> GetByOrdersOfClient(string username) //Metoda pro vypsání všech objednávek jistého uživatele
        {

            using (SqlCommand command = new SqlCommand("SELECT * FROM Order_ WHERE client_id in(SELECT id FROM Client WHERE username = @username)", _connection))
                {

                command.Parameters.Add(new SqlParameter("@username", username));
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
                        Tag = reader[2].ToString(),
                        Price = Convert.ToInt32(reader[3].ToString())
                    };
                    yield return product;
                }
                reader.Close();
            }
        }
    }
}
    
