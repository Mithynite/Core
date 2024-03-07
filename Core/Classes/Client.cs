namespace Core.Classes
{
    public class Client : StandardTable
    {
        private string email;
        private string username;

        public Client(string email, string username)
        {
            this.email = email;
            this.username = username;
        }
    }
}