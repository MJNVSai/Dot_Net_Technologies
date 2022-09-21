using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Relational
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 453;
            Console.WriteLine("Addition : " + (a + b));
            Console.WriteLine("Subraction : " + (a - b));
            Console.WriteLine("Multiplication : " + (a * b));
            Console.WriteLine("Division : " + (a / b));
            Console.WriteLine("Remainder : " + (a % b));

            int c = 22;
            if(a < b)
            {
                Console.WriteLine("A is lesser than B");
            }
            else if(b > c)
            {
                Console.WriteLine("B is greater than C");
            }
            else if(a != c)
            {
                Console.WriteLine("Both A and B are different");
            }
        }
    }
}
