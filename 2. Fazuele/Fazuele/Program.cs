
using Fazuele.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Fazuele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product;
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product = new ImportedProduct(name, price, fee);
                    products.Add(product);
                }
                else if (resp == 'u' || resp == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manudate = DateTime.Parse(Console.ReadLine());
                    product = new UsedProduct(name, price, manudate);
                    products.Add(product);
                }
                else
                {
                    product = new Product(name, price);
                    products.Add(product);
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
