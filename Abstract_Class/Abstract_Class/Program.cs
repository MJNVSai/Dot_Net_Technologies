using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuboid c1 = new Cuboid(5, 10, 15);
            c1.Compute();

            Cube c2 = new Cube(2, 8, 4);
            c2.Compute();
        }
    }

    abstract class Polygon
    {
        public int l, b, h;
        public Polygon(int l, int b, int h)
        {
            this.l = l;
            this.b = b;
            this.h = h;
        }

        public abstract void Compute();
    }

    class Cuboid : Polygon
    {
        public Cuboid(int l, int b, int h) : base(l, b, h)
        {
            //base(l, b, h);
        }

        public override void Compute()
        {
            Console.WriteLine("Volume of Cuboid : " + (l * b * h));
        }
    }

    class Cube : Polygon
    {
        public Cube(int l, int b, int h) : base(l, b, h)
        {
            //base(l, b, h);
        }

        public override void Compute()
        {
            Console.WriteLine("Area of the Cube : " + (l * b * h));
        }
    }
}
