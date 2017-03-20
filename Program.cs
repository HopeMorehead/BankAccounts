using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccounts
{
    enum accountTypes { a1Checking = 1, a2Savings = 2, a3Reserved = 3 }

    class Program:Checking
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which account would you like to access?");
            foreach (accountTypes types in Enum.GetValues(typeof(accountTypes)))

            Console.WriteLine(types);
            int UserInput = int.Parse(Console.ReadLine());

            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Checking account information");
                    Console.WriteLine("What would you like to do today\n 4.Deposit \n 5.Withdrawal");
                   // Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Saving account information");
                    Console.WriteLine("What would you like to do today\n 4.Deposit \n 5.Withdrawal");
                    break;
                case 3:
                    Console.WriteLine("Reserved account information");
                    Console.WriteLine("What would you like to do today\n 4.Deposit \n 5.Withdrawal");
                    Reserved mation = new Reserved();
                    mation.Getinformatiion();
                    Console.WriteLine("No Withdrawal for Reserve account. Will be penalize! ");
                    break;
                  

            };
            int UserInput1 = int.Parse(Console.ReadLine());
            switch (UserInput1)
            {
                case 4:
                    Checking CheckDepositBank2 = new Checking();
                    CheckDepositBank2.deposit();
                    Accounts Info = new Accounts();
                    Info.Reciept();
                    break;
                case 5:
                    Checking With = new Checking();
                    With.Withdraw(100.00M);
                    Accounts Info1 = new Accounts();
                    Accounts inter = new Accounts();
                    inter.AddInterests();
                    Info1.Reciept();
                    break;

                default:
                    Console.WriteLine("invaild Response!");
                    break;

                    Accounts Info3 = new Accounts();

                    Info3.Reciept();
                    StreamWriter SW = new StreamWriter(@" Reciept.txt");

                    Info3.Reciept();

                    SW.WriteLine();
                    SW.Close();
            }
        }
        }
    }

