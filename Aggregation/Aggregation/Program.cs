using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("Sabhapathi Street", "Vijayawada", "A.P");
            Employee e = new Employee(156, "Rizwan", a1);
            e.display();
        }
    }

    class Address
    {
        public string addressLine, city, state;

        public Address(string a, string c, string s)
        {
            this.addressLine = a;
            this.city = c;
            this.state = s;
        }
    }

    class Employee
    {
        public int id;
        public string name;
        public Address address; // This is an aggregation : Has a Relationship

        public Employee(int i, string s, Address a)
        {
            this.id = i;
            this.name = s;
            this.address = a;
        }

        public void display()
        {
            Console.WriteLine("Emplyee id : " + id + "\nEmployee Name : " + name);
            Console.WriteLine("Address Line : " + address.addressLine + "\nCity : " + address.city + "\nState : " + address.state);
        }
    }

}
