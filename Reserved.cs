using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Reserved : Checking

    {


        public override void deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            decimal num = Convert.ToInt32(Console.ReadLine());
            decimal current = MinimumAmount += num;
            Console.WriteLine("Current Balance is :" + current);
        }

        public override void Withdraw(decimal MinimumAmount)
        {
            Console.WriteLine("How much would you like to withdrawal?");
            decimal num = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            decimal current = MinimumAmount -= num;
            Console.WriteLine("Current Balance is :" + current);
        }


        public virtual void Getinformatiion()
        {

            decimal sunday = 60.00M;
            decimal monday = 60.00M;
            decimal tuesday = 60.00M;
            decimal wednesday = 60.00M;
            decimal thursday = 60.00M;
            decimal friday = 60.00M;
            decimal saturday = 60.00M;
            decimal workWeek = sunday + monday + tuesday + wednesday + thursday + friday + saturday;
            decimal biWeeklys = 2 * workWeek;
            decimal minimumBalance = 100.00M;

            decimal depositFunds = decimal.Parse(Console.ReadLine());
            decimal currentPositiveBalance = minimumBalance + depositFunds;
          

            int i = 0;
            while (i <= 4)
            {
                i++;

                minimumBalance += 00.00M;
                Console.WriteLine(currentPositiveBalance);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

                while (i != 2620.00)
                {
                    Console.WriteLine("Direct Deposit Monday - Friday");
                    break;

                }
            }
        }
    }
}             
                
            
