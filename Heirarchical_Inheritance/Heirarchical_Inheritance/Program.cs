using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heirarchical_Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            d.Bark();
            d.Hungar();

            Console.WriteLine();

            c.Hungar();
            c.Sleep();
        }
    }

    class Animal
    {
        public void Hungar()
        {
            Console.WriteLine(" I am Hungary ");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(" Barking ");
        }
    }

    class Cat : Animal
    {
        public void Sleep()
        {
            Console.WriteLine(" Sleeping ");
        }
    }
}
