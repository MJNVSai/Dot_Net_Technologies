using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiLevel_Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            BabyDog bd = new BabyDog();
            bd.eat();
            bd.weep();
            bd.Bark();
        }
    }

    class Animal
    {
        public void eat()
        {
            Console.WriteLine(" Eating ");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(" Barking ");
        }
    }

    class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine(" Weeping ");
        }
    }
}
