using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Constructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Satya");
            Account a2 = new Account(102, "Deva");

            a1.Display();
            a2.Display();
        }
    }

    class Account
    {
        public int id;
        public string name;
        public static float RateInterest;

        public Account(int id, string name)
        {
            Console.WriteLine(" Parameterized Constructor Invoked ");
            this.id = id;
            this.name = name;
        }

        static Account()
        {
            Console.WriteLine(" Static Constructor Invoked ");
            RateInterest = 8.7f;
        }

        public void Display()
        {
            Console.WriteLine("\n\nEmployee ID : " + id + "\nEmployee Name : " + name + "\nRate of Interest : " + RateInterest);
        }
    }
}
