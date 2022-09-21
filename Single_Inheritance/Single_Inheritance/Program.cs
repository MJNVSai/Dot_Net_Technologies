using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Programmer p = new Programmer();
            Console.WriteLine("Employee Salary : " + p.salary);
            Console.WriteLine("Employee Bonus : " + p.bonus);
        }
    }

    class Employee
    {
        public float salary = 40000;
    }

    class Programmer : Employee
    {
        public float bonus = 10000;
    }
}
