namespace lilshop.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
