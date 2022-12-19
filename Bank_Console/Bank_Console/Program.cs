using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAccount ca = new CheckAccount();
            Console.WriteLine("Initial Amount in Account : " + ca.amount);

            ca.ProcessCheck(2000);
            Console.WriteLine("Total Amount after WithDraw : " + ca.amount);

            ca.Deposit(6000);
            Console.WriteLine("Total amount after Deposited : " + ca.amount);

            SavingsAccount sa = new SavingsAccount();
            sa.DepositMonthlyInterest();
            Console.WriteLine(" Amount with Interest : " + sa.amount);

        }
    }

    class BankAccount
    {
        public string owner;
        public float balance;
        public float amount = 10000;

        public void Deposit(float new_amount)
        {
            this.amount = this.amount + new_amount;
        }

        public void WithDrawl(float old_amount)
        {
            this.amount = this.amount - old_amount;
        }
    }

    class CheckAccount : BankAccount
    {
        public float InsufficentFee;

        public void ProcessCheck(float check_amount)
        {
            if (check_amount > base.amount)
            {
                Console.WriteLine(" You Don't Have Sufficent Amount in Account");
            }
            else
            {
                base.WithDrawl(check_amount);
            }
        }
    }

    class SavingsAccount : BankAccount
    {
        public float AnnualInterest = 0.9f;

        public void DepositMonthlyInterest()
        {
            base.amount = base.amount * AnnualInterest;
        }
    }
}
