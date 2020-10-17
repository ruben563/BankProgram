using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount saving = new SavingsAccount();
            ChequingAccount chequing = new ChequingAccount();
            GlobalSavingsAccount global = new GlobalSavingsAccount();


            try
            {
                bool ans;



                string ansInt;

                do
                {
                    Console.WriteLine("***Bank Menu***\n" +
                        "A: Savings\n" +
                        "B: Chequing\n" +
                        "C: GlobalSavings\n" +
                        "Q: Exit");
                    ansInt = Console.ReadLine().ToUpper();

                    //******************************************************************************

                    if (ansInt == "A")
                    {
                        bool ans2;
                        do
                        {

                            string ansInt2;
                            Console.WriteLine("***Savings Menu***\n" +
                            "A: Deposit\n" +
                            "B: Withdrawal\n" +
                            "C: Close + Report\n" +
                            "R: Return to Bank Menu");
                            ansInt2 = Console.ReadLine().ToUpper();

                            ans2 = true;

                            if (ansInt2 == "A")
                            {
                                try
                                {
                                    string depInt;
                                    double dep;

                                    Console.WriteLine("Enter the amount of your deposit: ");
                                    depInt = Console.ReadLine();
                                    dep = double.Parse(depInt);

                                    saving.MakeDeposit(dep);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }

                                ans2 = true;
                            }
                            else if (ansInt2 == "B")
                            {
                                try { 
                                    string withInt;
                                    double with;
                                    Console.WriteLine("Enter the amount of your withdrawal: ");
                                    withInt = Console.ReadLine();
                                    with = double.Parse(withInt);
                                    saving.MakeWithdrawl(with);
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }
                                
                                
                                ans2 = true;

                            }
                            else if (ansInt2 == "C")
                            {
                                Console.WriteLine("Displaying you report card");
                                Console.ReadLine();
                                saving.CloseAndReport();
                                ans2 = true;
                            }
                            else if (ansInt2 == "R")
                            {
                                ans2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Oups error");
                                Console.ReadLine();
                                ans2 = true;
                            }
                        } while (ans2 == true);

                        ans = true;
                    }


                    //*******************************************************************************
                    else if (ansInt == "B")
                    {
                        bool ans3 = false;
                        do
                        {

                            string ansInt3;
                            Console.WriteLine("***Chequing Menu***\n" +
                            "A: Deposit\n" +
                            "B: Withdrawal\n" +
                            "C: Close + Report\n" +
                            "R: Return to Bank Menu");
                            ansInt3 = Console.ReadLine().ToUpper();

                            if (ansInt3 == "A")
                            {

                                string depInt2;
                                double dep2;
                                try
                                {
                                    Console.WriteLine("Enter the amount of your deposit: ");
                                    depInt2 = Console.ReadLine();
                                    dep2 = double.Parse(depInt2);

                                    chequing.MakeDeposit(dep2);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }
                                ans3 = true;
                            }
                            else if (ansInt3 == "B")
                            {

                                try
                                {
                                    string withInt2;
                                    double with2;
                                    Console.WriteLine("Enter the amount of your withdrawal: ");
                                    withInt2 = Console.ReadLine();
                                    with2 = double.Parse(withInt2);
                                    chequing.MakeWithdrawl(with2);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }


                                ans3 = true;

                            }
                            else if (ansInt3 == "C")
                            {
                                Console.WriteLine("Displaying you report card");
                                Console.ReadLine();
                                chequing.CloseAndReport();
                                ans3 = true;
                            }
                            else if (ansInt3 == "R")
                            {
                                ans3 = false;
                            }
                        } while (ans3 == true);

                        
                        ans = true;
                    }
                    //******************************************************************************
                    else if (ansInt == "C")
                    {

                        bool ans4 = false;
                        do
                        {
                            
                            string ansInt4;
                            Console.WriteLine("***Global Savings Menu***\n" +
                            "A: Deposit\n" +
                            "B: Withdrawal\n" +
                            "C: Close + Report\n" +
                            "D: Report Balance in USD\n" +
                            "R: Return to Bank Menu");
                            ansInt4 = Console.ReadLine().ToUpper();

                            if (ansInt4 == "A")
                            {

                                string depInt3;
                                double dep3;
                                try
                                {
                                    Console.WriteLine("Enter the amount of your deposit: ");
                                    depInt3 = Console.ReadLine();
                                    dep3 = double.Parse(depInt3);

                                    global.MakeDeposit(dep3);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }
                                ans4 = true;
                            }
                            else if (ansInt4 == "B")
                            {

                                try
                                {
                                    string withInt3;
                                    double with3;
                                    Console.WriteLine("Enter the amount of your withdrawal: ");
                                    withInt3 = Console.ReadLine();
                                    with3 = double.Parse(withInt3);
                                    global.MakeWithdrawl(with3);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.ReadLine();
                                }


                                ans4 = true;

                            }
                            else if (ansInt4 == "C")
                            {
                                Console.WriteLine("Displaying you report card");
                                Console.ReadLine();
                                global.CloseAndReport();
                                ans4 = true;
                            }
                            else if(ansInt4 == "D")
                            {
                               
                                    
                                    Console.WriteLine("Here is your balance in USD : " + global.USValue(0.76));
                                    Console.ReadLine();
                                
                            }
                            else if (ansInt4 == "R")
                            {
                                ans4 = false;
                            }
                        } while (ans4 == true);

                        ans = true;
                    }
                    //*********************************************************************************
                    else if (ansInt == "Q")
                    {
                        ans = false;
                    }
                    //********************************************************************************
                    else
                    {
                        Console.WriteLine("Oups an error");

                        ans = true;
                    }

                } while (ans == true);


            }












            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }


        }
    }
}
