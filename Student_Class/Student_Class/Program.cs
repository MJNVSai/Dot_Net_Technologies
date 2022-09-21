using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a class Student with the filed sno, sname, marks in three subjects.
            // Create a method SetStudentDetails() which will read the information from the student.
            // Create another method GetStudentDetails() which will display the information. Also,
            // another method to compute the average mark of the student in three subject.
            // Display the information.

            Student obj = new Student();
            obj.SetStudentDetails();
            Console.WriteLine();
            obj.GetStudentDetails();
        }
    }

    class Student
    {
        public int sno;
        public string sname;
        public Decimal marks;

        public void SetStudentDetails()
        {
            Console.Write("Enter the Student Number : ");
            sno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student Name : ");
            sname = Console.ReadLine();
            Console.Write("Enter the Student Total marks : ");
            marks = Convert.ToDecimal(Console.ReadLine());
        }

        public void GetStudentDetails()
        {
            Console.WriteLine("Student Number is : " + sno);
            Console.WriteLine("Student Name : " + sname);
            Console.WriteLine("Student Marks : " + marks);
        }
    }
}
