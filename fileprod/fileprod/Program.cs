using fileprod.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace fileprod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product;
            List<Product> list = new List<Product>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] aux = sr.ReadLine().Split(',');
                        string name = aux[0];
                        double price = double.Parse(aux[1], CultureInfo.InvariantCulture);
                        product = new Product(name, price);
                        list.Add(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            double average = list.Average(p => p.Price);
            Console.WriteLine("Average price: " + average.ToString("C2"));

            var selected = list.Where(p => p.Price < average).OrderByDescending(p => p.Name);
            foreach (Product p in selected)
            {
                Console.WriteLine(p.Name);
            }

        }
    }
}
