using leaozinho.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace leaozinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxedEntity entity;
            List<TaxedEntity> taxList = new List<TaxedEntity>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double yearincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Health expenses: ");
                    double healthexpense = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    entity = new Person(name, yearincome, healthexpense);
                    taxList.Add(entity);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int empNum = int.Parse(Console.ReadLine());
                    entity = new Company(name, yearincome, empNum);
                    taxList.Add(entity);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double taxsum = 0.0;
            foreach (TaxedEntity ent in taxList)
            {
                Console.WriteLine(ent.Name + ": " + ent.Tax().ToString("C2"));
                taxsum += ent.Tax();
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: " + taxsum.ToString("C2"));
        }
    }
}
