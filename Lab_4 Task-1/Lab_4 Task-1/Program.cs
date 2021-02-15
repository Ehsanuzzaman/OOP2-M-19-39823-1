using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, j;
            Console.Write("Sum of element in array:\n");


            Console.Write("\nInput the number of elements of the array :");


            n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[100];

            for (i = 1; i <= n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = arr[n]; j >= arr[1]; j--)
            {
                Console.Write(j);
            }

        }
    }
}