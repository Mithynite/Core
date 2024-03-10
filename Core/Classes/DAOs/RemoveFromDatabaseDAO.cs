using System.Data.SqlClient;

namespace Core.Classes.DAOs
{
    public class RemoveFromDatabase : DAO
    {
        public string RemoveClient(string username)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Order_item " +
                                                   "WHERE order_id IN (SELECT id FROM Order_ WHERE client_id = " +
                                                   "(SELECT id from Client where username = @username))", _connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Order_ WHERE client_id = (SELECT id from Client where username = @username)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Client WHERE username = @username";
                cmd.ExecuteNonQuery();
            }
            return $"Client {username} was unfortunately removed ;(, but at least successfully :)";
        }
        
        public string RemoveOrder(int number)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Order_item " +
                                                   "WHERE order_id = (SELECT id FROM Order_ WHERE number = @orderNumber)", _connection))
            {
                cmd.Parameters.AddWithValue("@orderNumber", number);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Order_ WHERE number=@orderNumber";
                cmd.ExecuteNonQuery();
            }
            return $"Order number {number} was successfully deleted :)";
        }
        public string RemoveProduct(string tag)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Order_item WHERE product_id = (SELECT id FROM Product WHERE tag = @prodtag)", _connection))
            {
                cmd.Parameters.AddWithValue("@prodtag", tag);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Product WHERE tag = @prodtag";
                cmd.ExecuteNonQuery();
            }
            return $" Product {tag} was successfully removed :)";
        }
    }
}