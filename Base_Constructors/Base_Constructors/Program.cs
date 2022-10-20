using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Constructors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Python obj = new Python();
            Python obj1 = new Python(50, "C++", 500);
            obj.show();
            Console.WriteLine();
            obj1.show();
        }
    }

    class Book
    {
        public int bno;
        public string bname;
        public float bcost;

        public Book()
        {
            bno = 45;
            bname = "OOPS With Java";
            bcost = 250;
        }

        public Book(int bno, string bname, float bcost)
        {
            this.bno = bno;
            this.bname = bname;
            this.bcost = bcost;
        }
    }

    class Python : Book
    {
        // Calling base class default and parameterized constructors through derived class

        public Python() : base()
        {
            Console.WriteLine(" Python Constructor ");
        }

        public Python(int bno, string bname, float bcost) : base(bno, bname, bcost)
        {
            Console.WriteLine("Python Parameterized Constructor ");
        }

        public void show()
        {
            Console.WriteLine(" Book Number : " + bno);
            Console.WriteLine(" Book name : " + bname);
            Console.WriteLine(" Book Cost : " + bcost);
        }
    }
}
