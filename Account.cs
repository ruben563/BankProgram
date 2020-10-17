using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    public abstract class Account : IAccount
    {

        public enum Activity { ACTIVE, UNACTIVE};
        
        

        public static double balance = 5;

        public double Balance
        {
            get { return balance; }
        }

        public double annualInterestRate;

        public double AnnualInterestRate
        {
            get { return AnnualInterestRate; }
            set { annualInterestRate = value; }
        }





        public void CalculateInterest()
        {
            double MonthlyInterestRate = (AnnualInterestRate / 12);
            double MonthlyInterest = Balance * MonthlyInterestRate;
            balance = Balance + MonthlyInterest;
        }




        public virtual string CloseAndReport()
        {

            Console.WriteLine("This month's balance: " + balance);
            balance = 0;

            return "New balance";
        }


        public static double counter;
        public static double charges;
        public virtual void MakeDeposit(double amount)
        {
            counter++;
            for(int i =0; i < counter; i++)
            {
                charges += 0.10;
            }

            balance += amount;

            
            
                    Console.WriteLine("Here is your balance: " + balance);
                    Console.ReadLine();
                
        }



        public static double counter2;
        public virtual void MakeWithdrawl(double amount)
        {
            counter2++;

            balance -= amount;




            Console.WriteLine("Here is your balance: " + balance);
            Console.ReadLine();




        }

    }
}
