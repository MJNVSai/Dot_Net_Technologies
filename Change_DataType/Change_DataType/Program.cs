using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_DataType
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that performs implicit and explicit type conversions.
            double Explict_var = 5678.54;
            int explict = (int)Explict_var;
            Console.WriteLine("Explict Type Conversion : " + explict);

            // implict Type Conversions.
            int number = 756;
            Console.WriteLine("Int to String : " + number.ToString());
            
        }
    }
}
