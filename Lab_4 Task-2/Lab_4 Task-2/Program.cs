using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, sum = 0;

            Console.Write("Sum of element in array:\n");


            Console.Write("Input the number of elements of the array :");

            n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[100];

            for (i = 1; i <= n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.Write(sum);

        }
    }
}


