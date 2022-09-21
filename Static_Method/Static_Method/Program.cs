using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            emp.change();
            emp obj = new emp();
            obj.Set();
            Console.WriteLine();
            obj.Display();
        }
    }

    class emp
    {
        public int Sno;
        public string ename;
        public static string company = "Google";

        public static void change()
        {
            company = "Amazon";
        }

        public void Set()
        {
            Console.Write("Enter Employee number : ");
            Sno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee's name : ");
            ename = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Employee's Number : " + Sno);
            Console.WriteLine("Employee's Name : " + ename);
            Console.WriteLine("Comapany Name : " + company);
        }
    }
}
