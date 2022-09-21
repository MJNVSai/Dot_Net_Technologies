using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4,5);
            Console.WriteLine("Area of the Rectangle with parameterized values");
            r.Area_Rectangle();

            Console.WriteLine();

            Console.WriteLine("Area of the Rectangle with Customized values : ");
            r.width = 10;
            r.height = 20;
            r.Area_Rectangle();

        }
    }

    public struct Rectangle
    {
        public int width, height;

        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public void Area_Rectangle()
        {
            Console.WriteLine("Area of the Rectangle : " + (width * height));
        }
    }
}
