using ExceptionBank.Ent;
using System;
using System.Globalization;

namespace ExceptionBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc;
            Console.WriteLine("Enter account data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double depo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            acc = new Account(number, holder, depo, limit);

            Console.WriteLine();
            Console.Write("Enter the amount for withdraw: ");
            double wd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(wd);
                Console.WriteLine("New balance: " + acc.Balance.ToString("C2"));
            }
            catch (AppException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}
