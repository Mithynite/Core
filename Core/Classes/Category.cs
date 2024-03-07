namespace Core.Classes
{
    public class Category : StandardTable
    {
        private string title;
        private string note;

        public Category(string title, string note)
        {
            this.title = title;
            this.note = note;
        }
    }
}