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
        
        public void InsertNewOrder(Order order, string clientUsername)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Order_ (number, mark, client_id, record_date) VALUES (@number, @mark, " +
                                                   "(select id from Client where username=@clientUsername), @recordDate)", _connection))
            {
                cmd.Parameters.AddWithValue("@number", order.Number);
                cmd.Parameters.AddWithValue("@mark", order.Mark);
                cmd.Parameters.AddWithValue("@clientUsername", clientUsername);
                cmd.Parameters.AddWithValue("@recordDate", DateTime.Today);
                
                cmd.ExecuteNonQuery();//TODO idk
            }
        }
        public void InsertNewClient(Client client)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Client (username, mark) VALUES (@number, @mark)", _connection))
            {
                cmd.Parameters.AddWithValue("@username", client.Username);
                cmd.Parameters.AddWithValue("@email", client.Email);
                
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertNewCategory(Category category)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Category (title, note) VALUES (@title, @note)", _connection))
            {
                cmd.Parameters.AddWithValue("@title", category.Title);
                cmd.Parameters.AddWithValue("@note", category.Note);
                
                cmd.ExecuteNonQuery();
            }
        }
        
        public void InsertNewProduct(Product product, string categoryTitle)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Product (tag, price, category_id) VALUES (@tag, @price, " +
                                                   "(SELECT id FROM Category WHERE title = @categoryTitle))", _connection))
            {
                cmd.Parameters.AddWithValue("@tag", product.Tag);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@categoryTitle", categoryTitle);

                cmd.ExecuteNonQuery();
            }
        }
        
        
        public void AddItemToOrder(int orderNumber, string productTag)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO  Order_item(order_id, product_id) VALUES " +
                                                   "((SELECT id FROM Order_ WHERE number = @orderNumber), " +
                                                   "(SELECT id FROM Product WHERE tag = @productTag))", _connection))
            {
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                cmd.Parameters.AddWithValue("@productTag", productTag);

                cmd.ExecuteNonQuery();
            }
        }
        
        
    }

}