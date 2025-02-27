using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceJuros.Services
{
    class PaypalService : OnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount += amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount += amount * 0.01 * months; 
        }
    }
}
