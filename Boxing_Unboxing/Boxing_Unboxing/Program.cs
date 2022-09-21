using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Boxing : assigning variable to object...
            int var = 345;
            object obj = var;
            var = 500;
            Console.WriteLine("Value Stored in var is : {0}", var);
            Console.WriteLine("Value Stored in obj is : {0}", obj);

            // Unboxing : reverse of boxing....
            int unbox = (int)var;
            Console.WriteLine("Value Stored in unbox is : {0}", unbox);
        }
    }
}
