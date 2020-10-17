using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
      public class SavingsAccount : Account, IAccount
    {
        Activity activity = Activity.ACTIVE;



        public override string CloseAndReport()
        {
            if (counter > 4)
            {
                for (int i = 1; i < counter; i++)
                {
                    balance -= 1;
                }
            }

            return base.CloseAndReport(); ;
            
        }



        public override void MakeDeposit(double amount)
        {
            if((Balance+amount) > 25)
            {
                activity = Activity.ACTIVE;
                if(activity == Activity.ACTIVE)
                {
                    Console.WriteLine("Accessing your account");
                    Console.ReadLine();
                    base.MakeDeposit(amount);
                    
                }
                else
                {
                    Console.WriteLine("Your account is unactive");
                    Console.ReadLine();
                }
            }
        }




        public override void MakeWithdrawl(double amount)
        {
            if (activity == Activity.ACTIVE)
            {
                Console.WriteLine("You are accessing your account");
                Console.ReadLine();
                base.MakeWithdrawl(amount);
            }
            else
                Console.WriteLine("You account is unactive");
        }

    }
}
