using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Print Even Number :");
            n = 20;
            for(i = 1; i<=20;i++)
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
           
        }
    }
}
