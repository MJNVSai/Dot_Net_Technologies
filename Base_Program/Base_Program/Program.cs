using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Eat();
            c.show();
        }
    }

    class Animal
    {
        public string color = "White";
        public Animal()
        {
            Console.WriteLine("This is a Animal Class Constructor");
        }
    }

    class Dog : Animal
    {
        public string color = "Black";
        public void show()
        {   // Calling the base class field attributes
            Console.WriteLine("Parent Class Field Color : " + base.color); 
            Console.WriteLine("Child Class Field Color : " + color);
        }

        public virtual void Eat()
        {
            Console.WriteLine(" I am Eating Food ");
        }
    }

    class Cat : Dog
    {
        public override void Eat()
        {
            base.Eat(); // Calling the base class method
            Console.WriteLine(" Drinking Milk ");
        }
    }
}
