using InterfaceJuros.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace InterfaceJuros.Services
{
    class ContractService
    {
        private OnlinePaymentService OnPaySvc;

        public ContractService(OnlinePaymentService onPaySvc)
        {
            OnPaySvc = onPaySvc;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double monthValue = (double)(contract.TotalValue / months);
            for (int i = 1; i <= months; i++)
            {
                DateTime DateAux1 = contract.Date;
                double ValueAux1 = OnPaySvc.Interest(monthValue, i);
                DateTime DateAux2 = DateAux1.AddMonths(i);
                double ValueAux2 = OnPaySvc.PaymentFee(ValueAux1);
                contract.AddInstallment(new Installment(DateAux2, ValueAux2));
            }
        }
    }
}
