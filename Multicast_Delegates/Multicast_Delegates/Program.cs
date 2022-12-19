using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    internal class Program
    {
        public delegate void delmethod(int x, int y);

        public void plus_Method1(int x, int y)
        {
            Console.Write("You are in plus_Method");
            Console.WriteLine(x + y);
        }

        public void subtract_Method2(int x, int y)
        {
            Console.Write("You are in subtract_Method");
            Console.WriteLine(x - y);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            delmethod del = new delmethod(obj.plus_Method1);

            // Here we have multicast  
            del += new delmethod(obj.subtract_Method2);
            // plus_Method1 and subtract_Method2 are called  
            del(50, 10);
            Console.WriteLine();
            //Here again we have multicast  
            del -= new delmethod(obj.plus_Method1);
            //Only subtract_Method2 is called  
            del(20, 10);
            Console.ReadLine();

        }
    }
}
