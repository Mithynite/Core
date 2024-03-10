using System.Data.SqlClient;
using Core.Classes.DAOs;

namespace Core.Classes
{
    public class EditDatabaseDAO : DAO
    {
        public string EditClient(string currentUsername, Client client)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Client SET username = @username, email = @email WHERE username = @currentUsername", _connection))
            {
                cmd.Parameters.AddWithValue("@currentUsername", currentUsername);
                cmd.Parameters.AddWithValue("@username", client.Username);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.ExecuteNonQuery();
            }
            return $"Client {currentUsername} has been modified to {client}";
        }
        
        public string EditProduct(string currentTag, Product product)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Product SET tag = @newTag, price = @nPrice WHERE tag = @currentTag", _connection))
            {
                cmd.Parameters.AddWithValue("@currentTag", currentTag);
                cmd.Parameters.AddWithValue("@newTag", product.Tag);
                cmd.Parameters.AddWithValue("@nPrice", product.Price);
                cmd.ExecuteNonQuery();
            }
            return $"Product {currentTag} has been modified to {product}";
        }
        
        public string EditCategory(string currentTitle, Category category)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Category SET title = @newTitle, note = @nNote WHERE title = @currentTitle", _connection))
            {
                cmd.Parameters.AddWithValue("@currentTitle", currentTitle);
                cmd.Parameters.AddWithValue("@newTitle", category.Title);
                cmd.Parameters.AddWithValue("@nNote", category.Note);
                cmd.ExecuteNonQuery();
            }
            return $"Category {currentTitle} has been modified to {category}";
        }
        
    }
}