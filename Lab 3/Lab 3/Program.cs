using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ehsanuzzaman", "19-39823-1", "CSE", 3.80);
            student.ShowInfo();
            Console.WriteLine();
            Triangle triangle = new Triangle(2, 4, 6);
            triangle.TestTriangle();
            Console.WriteLine();
            Account account = new Account("Ehsanuzzaman", "454ES5455", 50000);
            account.Deposit(4000);
            account.Withdraw(2000);
            Console.WriteLine();
            Course courses = new Course("Object Oriented Programming 2", "25455", 3);
            courses.ShowCourseInfo();
            Console.ReadKey();
        }
    }
}
