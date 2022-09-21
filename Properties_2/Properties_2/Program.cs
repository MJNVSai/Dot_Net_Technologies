using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int roll;
            Student obj = new Student();

            Console.Write("Enter Student's Roll Number in Section A : ");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            obj.sr = roll;
            Console.WriteLine("The Student's Roll Number When He is Changed From Section A to Section B is : " + obj.sr);

            Console.WriteLine();
        }
    }

    class Student
    {
        protected int Stu_id;

        public int sr
        {
            get { return Stu_id; }

            set { Stu_id = value + 3; }
        }
    }
}
