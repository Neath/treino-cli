using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaozinho.Entities
{
    internal class Person : TaxedEntity
    {
        public double HealthCosts { get; set; }

        public Person() { }

        public Person(string name, double yearIncome, double healthCosts) : base(name, yearIncome)
        {
            HealthCosts = healthCosts;
        }

        public override double Tax()
        {
            double taxvalue = 0.0;
            if (YearIncome >= 20000.00)
            {
                taxvalue += (double)((YearIncome * 0.25) - (HealthCosts * 0.5));
            }
            else
            {
                taxvalue += (double)((YearIncome * 0.15) - (HealthCosts * 0.5));
            }
            return taxvalue;
        }

    }
}
