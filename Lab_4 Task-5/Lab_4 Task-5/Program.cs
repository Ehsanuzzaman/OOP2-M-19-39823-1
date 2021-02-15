using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0;
            int[] arr5 = new int[100];
            int i, j, k;
            Console.Write("Printing all unique elements of the array:\n");
            Console.Write("Input the number of the array :");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} elements into the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr5[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("The unique elements into the array are : \n");
            for (i = 0; i < n; i++)
            {
                count = 0;
                
                for (j = 0; j < i - 1; j++)
                {
                    
                    if (arr5[i] == arr5[j])
                    {
                        count++;
                    }
                }
               
                for (k = i + 1; k < n; k++)
                {
                   
                    if (arr5[i] == arr5[k])
                    {
                        count++;
                    }
                   
                    if (arr5[i] == arr5[i + 1])
                    {
                        i++;
                    }
                }
               
                if (count == 0)
                {
                    Console.Write("{0} ", arr5[i]);
                }
            }
            Console.WriteLine("\n");
        }
    }
}

      
    

