using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    public delegate void Transformer(int x);
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            int i = int.Parse(Console.ReadLine());

            Transformer t;

            t = Square;
            t += Cube;
            t.Invoke(i);

            Notification obj = new Notification();
            obj.transformerEvent += User1.Xhandler;
            obj.transformerEvent += User2.Yhandler;

            obj.Notifyall(i);
        }

        public static void Square(int x)
        {
            Console.WriteLine("Square of a Given Number : " + x * x);
        }

        public static void Cube(int x)
        {
            Console.WriteLine("Cube of a Given Number : " + x * x * x);
        }
    }

    class Notification
    {
        public event Transformer transformerEvent;

        public void Notifyall(int x)
        {
            if(transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }

    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event Received By user 1 Object ");
        }
    }

    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event Received By user 2 Object ");
        }
    }
}
