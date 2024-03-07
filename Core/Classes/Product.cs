namespace Core.Classes
{
    public class Product : StandardTable
    {
        private int category_id;
        private string tag;
        private float price;

        public int CategoryId
        {
            get => category_id;
            set => category_id = value;
        }

        public string Tag
        {
            get => tag;
            set => tag = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }

        public Product(int categoryId,string tag, float price)
        {
            category_id = categoryId;
            this.tag = tag;
            this.price = price;
        }

        public Product()
        {
            
        }

        public string ToString()
        {
            return $"Product : category id = {category_id}, tag = {tag}, price = {price}";
        }
    }
}