using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    internal class Program
    {
        public void Show(params int[] val) // Params Paramater  
        {
            Console.Write("List of all values : ");
            for (int i = 0; i < val.Length; i++)
            {
                Console.Write(val[i] + " ");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program(); // Creating Object  
            p.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
            p.Show(1, 2, 3, 4, 5);
        }
    }
}
