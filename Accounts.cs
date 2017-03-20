using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Accounts
    {
        protected decimal Withdrawal;
        protected decimal Deposit;
        protected decimal MinimumAmount = 100.00M;
        protected string name = "Adam Smith";
        protected long AccountNumber = 12345678909876L;
        decimal interestRate = 0.03M;

        public Accounts()
        {
        }

        public Accounts(decimal withdrawal_, decimal deposit_, decimal userInput_)
        {
            this.Withdrawal = withdrawal_;
            this.Deposit = deposit_;
            this.MinimumAmount = 100.00M;
            this.name = "Adam Smith";
        }

        public decimal withdrawal_
        {
            get
            {
                return this.Withdrawal;
            }
            set
            {
                this.Withdrawal = value;
            }
        }


        public decimal deposit_
        {
            get
            {
                return this.Deposit;
            }
            set
            {
                this.Deposit = value;
            }
        }


        public decimal MinimumAmount_
        {
            get
            {
                return this.MinimumAmount;

            }
            set
            {
                this.MinimumAmount = value;
            }
        }


        public virtual void AddInterests()
        {

            MinimumAmount *= (Decimal)interestRate;
        }

        public virtual void Reciept()
        {
            Console.WriteLine(name + AccountNumber + DateTime.Now.TimeOfDay);
        }


       

    }

}



  