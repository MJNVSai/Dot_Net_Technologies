using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Deva");
            Account a2 = new Account(105, "Shiva");
            a1.Display();
            Console.WriteLine();
            a2.Display();

            Console.WriteLine("\n Changing the Static field value");
            Account.RateOfInterest = 12.5f;
            a1 = new Account(106, "Satya");
            a2 = new Account(112, "Sai Vamsi");
            a1.Display();
            Console.WriteLine();
            a2.Display();
        }
    }
    
    class Account
    {
        public int accno;
        public string name;
        public static float RateOfInterest = 8.8f;

        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Account Number : " + accno + "\nAccount Holder : " + name + "\nRate of Interest : " + RateOfInterest);

        }
    }
}
