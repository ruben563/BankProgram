using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
     class GlobalSavingsAccount : SavingsAccount, IExchangable
    {
        public double USValue(double rate)
        {
            rate = 0.76;

            double usd = balance * rate;

            
            return usd;
        
        }

        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }

        public override void MakeWithdrawl(double amount)
        {
            base.MakeWithdrawl(amount);
        }

        public override string CloseAndReport()
        {
            return base.CloseAndReport();
        }

        


    }
}
