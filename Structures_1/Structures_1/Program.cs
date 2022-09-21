using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 5;
            rect.height = 4;

            Console.WriteLine("Area of the Rectangle : " + (rect.width * rect.height));
        }
    }

    public struct Rectangle
    {
        public int width, height;
    }
}
