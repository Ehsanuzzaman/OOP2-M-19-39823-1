using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5,7,8,7,5 };
            Console.WriteLine();

            Console.WriteLine("Total number of duplicate elements  are:");

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])

                        Console.WriteLine(arr1[j]);
                }
            }
        }
    }
}
    

