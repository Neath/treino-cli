using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaozinho.Entities
{
    internal class Company : TaxedEntity
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double yearIncome, int numberOfEmployees) : base(name, yearIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxvalue = 0.0;
            if (NumberOfEmployees > 10)
            {
                taxvalue += YearIncome * 0.14;
            }
            else
            {
                taxvalue += YearIncome * 0.16;
            }
            return taxvalue;
        }
    }
}
