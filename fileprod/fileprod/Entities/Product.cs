using System.Collections.Generic;

namespace fileprod.Entities
{
    class Product
    {
        List<Product> list = new List<Product>();

        public Product()
        {
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void AddProcut(Product prod)
        {
            list.Add(prod);
        }
    }
}
