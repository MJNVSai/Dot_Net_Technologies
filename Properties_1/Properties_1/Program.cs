using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person obj = new Person();

            Console.Write("Enter Book Number : ");
            obj.book_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Name : ");
            obj.name = Console.ReadLine();

            Console.Write("Enter No.of Pages in Book : ");
            obj.pages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book ISSN Number : ");
            obj.issn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Price : ");
            obj.price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Publishe Year : ");
            obj.pub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Book Number : " + obj.book_no);
            Console.WriteLine("Book Name : " + obj.name);
            Console.WriteLine("No.of Pages in That Book : " + obj.pages);
            Console.WriteLine("Book ISSN Number : " + obj.issn);
            Console.WriteLine("Book Price : " + obj.price);
            Console.WriteLine("Year of Published : " + obj.pub);
        }
    }

    class Person
    {
        public int book_no { get; set; }
        public string name { get; set; }
        public int pages { get; set; }
        public int issn { get; set; }
        public int price { get; set; }
        public int pub { get; set; }
    }
}
