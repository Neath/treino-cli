using System.Collections.Generic;

namespace fileprod.Entities
{
    class Product
    {
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
    }
}
