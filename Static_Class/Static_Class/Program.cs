using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is : " + Mymath.pi);
            Console.WriteLine("Cube of 4 is : " + Mymath.cube(4));
        }
    }

    public static class Mymath
    {
        public static float pi = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }
}
