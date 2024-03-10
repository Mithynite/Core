namespace Core.Classes
{
    public class Product : StandardTable
    {
        private string tag;
        private float price;

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

        public Product(string tag, float price)
        {
            this.tag = tag;
            this.price = price;
        }

        public Product()
        {
            
        }

        public override string ToString()
        {
            return $"Product : tag = {tag}, price = {price}";
        }
    }
}