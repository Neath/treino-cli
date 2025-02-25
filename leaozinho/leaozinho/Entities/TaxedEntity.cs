using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaozinho.Entities
{
    internal abstract class TaxedEntity
    {
        public string Name { get; set; }

        public double YearIncome { get; set; }

        public TaxedEntity() { }

        public TaxedEntity(string name, double yearIncome)
        {
            Name = name;
            YearIncome = yearIncome;
        }

        public abstract double Tax();
    }
}
