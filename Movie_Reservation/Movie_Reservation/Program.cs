using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Reservation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Reservation obj = new Reservation();
            obj.Movie_Set();
            Reservation.Tickets();
            Console.WriteLine();
            obj.Display();
        }
    }

    class Reservation
    {
        public static int tickets;
        public string UserName, Email;

        public void Movie_Set()
        {
            Console.Write("Enter username : ");
            UserName = Console.ReadLine();

            Console.Write("Enter Emil id : ");
            Email = Console.ReadLine();
        }

        public static void Tickets()
        {
            Console.Write("Enter No.of Movie Tickets : ");
            tickets = Convert.ToInt32(Console.ReadLine());
            tickets = tickets - 1;
        }

        public void Display()
        {
            Console.WriteLine("UserName : " + UserName);
            Console.WriteLine("Email ID : " + Email);
            Console.WriteLine("Reduced Tickets : " + tickets);
        }
    }
}
