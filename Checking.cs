using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Checking:Accounts
    {

        public virtual void deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            decimal num = Convert.ToInt32(Console.ReadLine());
            decimal current = MinimumAmount += num;
            Console.WriteLine("+" + num);
            Console.WriteLine("Current Balance is :+" + current);
        }

        public virtual void Withdraw(decimal MinimumAmount)
        {
            Console.WriteLine("How much would you like to withdrawal?");
            decimal num = Convert.ToInt32(Console.ReadLine());
            decimal current = MinimumAmount -= num;
            Console.WriteLine("-"+ num);
            Console.WriteLine("Current Balance is :" + current);
        }
        
        public override void Reciept()
        {
            Console.WriteLine(name + AccountNumber + DateTime.Now.TimeOfDay);
        }

    }
}

