using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value : ");

            int mark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Obtained Grade : ");

            if (mark >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (mark >= 85 & mark < 89)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 80 & mark < 84)
            {
                Console.WriteLine("B+");
            }
            else if (mark >= 75 & mark < 79)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 50 & mark < 75)
            {
                Console.WriteLine("C+");
            }

            else if (mark <= 50)
            {
                Console.WriteLine("F");
            }

            else
            {
                Console.WriteLine("failed");
            }

        }
    }
}
