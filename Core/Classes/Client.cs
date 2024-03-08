namespace Core.Classes
{
    public class Client : StandardTable
    {
        private string email;
        private string username;

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public Client(string email, string username)
        {
            this.email = email;
            this.username = username;
        }
    }
}