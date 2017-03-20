using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Saving:Checking
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

        public override void Reciept()
        {
            Console.WriteLine(name + AccountNumber + DateTime.Now.TimeOfDay);
        }
    }
}
