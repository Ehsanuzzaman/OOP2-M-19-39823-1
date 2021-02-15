using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;

            Console.Write("Copy the elements one array into another array :\n");
            Console.Write("Input the number of elements of the array :");
            
             n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }


            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.Write("\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n");
        }
    }
}
