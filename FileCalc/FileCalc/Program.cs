using FileCalc.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace FileCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "C:\\Users\\ddvil\\Documents\\DEV\\repos\\treino-cli\\FileCalc\\file.csv";
            string targetPath = "C:\\Users\\ddvil\\Documents\\DEV\\repos\\treino-cli\\FileCalc\\out\\summary.csv";
            List<Product> products = new List<Product>();

            try
            {
                string[] aux = File.ReadAllLines(sourcePath);

                for (int i = 0; i < aux.Length; i++)
                {
                    string[] prod = aux[i].Split(',');
                    string name = prod[0];
                    double price = double.Parse(prod[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(prod[2]);
                    Product product = new Product(name, price, quantity);
                    products.Add(product);
                }

                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    foreach (Product prod in products)
                    {
                        sw.WriteLine(prod);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
