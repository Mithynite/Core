namespace Core.Classes
{
    public class Category : StandardTable
    {
        private string title;
        private string note;

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public Category(string title, string note)
        {
            this.title = title;
            this.note = note;
        }
        
        public override string ToString()
        {
            return $"Category : title = {title}, note = {note}";
        }
    }
}