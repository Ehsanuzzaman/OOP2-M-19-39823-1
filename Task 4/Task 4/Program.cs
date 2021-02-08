using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int totaleven = 0;
           int totalodd = 0;
           Console.WriteLine("Enter the number from 1 to 100 :");
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" {0}", i);
                    totaleven = totaleven + i;

                }
                else
                {
                    Console.WriteLine("\t\t {0}", i);
                    totalodd = totalodd + i;
                }
            }
            Console.WriteLine(" \n\n Sum of All Even Numbers are : {0} \n\n Sum of All Odd Numbers are : {1}", totaleven, totalodd);
            Console.Read();
        }
    }
}

