using lilshop.Entities;
using lilshop.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace lilshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product;
            OrderItem orderItem;
            Order order;

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthdate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int orderquantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= orderquantity; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string productname = Console.ReadLine();

                Console.Write("Product price: ");
                double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int productquantity = int.Parse(Console.ReadLine());

                product = new Product(productname, productprice);
                orderItem = new OrderItem(productquantity, productprice, product);

                order.AddItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
