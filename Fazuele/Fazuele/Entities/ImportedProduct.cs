using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazuele.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            CustomsFee = customsfee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(TotalPrice().ToString("C2"));
            sb.Append(" (Customs fee: ");
            sb.Append(CustomsFee.ToString("C2"));
            sb.Append(")");
            return sb.ToString();
        }
    }
}
