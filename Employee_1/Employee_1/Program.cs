using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_1
{
    public class Program
    {
        public decimal total = 0;
        public static void Main(string[] args)
        {
            decimal T = 0;
            Employee[] obj = new Employee[10];

            for(int i = 0; i < 3; i++)
            {
                obj[i] = new Employee();
                obj[i].SetStudentDetails();
                Console.WriteLine();
                obj[i].GetStudentDetails();

                decimal t = obj[i].salary;
                T = T + t;
            }

            Console.WriteLine("Total Salary of all Employee's is : " + T);
            
        }
    }

    class Employee
    {
        public int eno, pincode;
        public string ename, address, designation, city;
        public decimal salary;
        public double mobile;

        public void SetStudentDetails()
        {
            Console.Write("Enter Employee number : ");
            eno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            ename = Console.ReadLine();

            Console.Write("Enter Employee Location Address : ");
            address = Console.ReadLine();

            Console.Write("Enter Employee Designation : ");
            designation = Console.ReadLine();

            Console.Write("Enter Employee's Mobile number : ");
            mobile = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Employee Salary : ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Employee Located City's Name : ");
            city = Console.ReadLine();

            Console.Write("Enter Area pincode : ");
            pincode = Convert.ToInt32(Console.ReadLine());
        }

        public void GetStudentDetails()
        {
            Console.WriteLine("Employee Number : " + eno);
            Console.WriteLine("Employee's Name : " + ename);
            Console.WriteLine("Employee Address : " + address);
            Console.WriteLine("Employee Designation : " + designation);
            Console.WriteLine("Employee's Mobile Number : " + mobile);
            Console.WriteLine("Employee's Salary : " + salary);
            Console.WriteLine("Employee City : " + city);
            Console.WriteLine("Employee Area Pincode : " + pincode);
        }
    }
}
