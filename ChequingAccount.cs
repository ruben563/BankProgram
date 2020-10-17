using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    class ChequingAccount : Account
    {

        public override void MakeWithdrawl(double amount)
        {
            if((balance-amount) < 0)
            {
                amount = 15;
                base.MakeWithdrawl(amount);
            }
            else
            base.MakeWithdrawl(amount);
        }


        public override string CloseAndReport()
        {
            double monthlyService = 5;
            balance = balance - (monthlyService + charges);


            return base.CloseAndReport();
        }

        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }


    }
}
