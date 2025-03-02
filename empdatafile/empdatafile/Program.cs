using empdatafile.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace empdatafile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double minsalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] aux = sr.ReadLine().Split(',');
                        string name = aux[0];
                        string email = aux[1];
                        double salary = double.Parse(aux[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            var Emp = list.Where(f => f.Salary > minsalary).OrderBy(p => p.Name);
            var salarySum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            foreach (Employee emp in Emp)
            {
                Console.WriteLine(emp.Email);
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salarySum.ToString("C2"));

        }
    }
}
