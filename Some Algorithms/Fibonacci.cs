using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Algorithms
{
    class Fibonacci
    {
        public static int FibonacciFunc(int n)
        {
     
            int a = 1;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            /*
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(FibonacciFunc(i));
            }
            Console.Read();
            */

            Console.WriteLine("Length of array = ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
           
            for(int i = 0; i < length; i ++)
            {
                Console.WriteLine("Populate the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Algorithms.BubbleSort(array);

            Console.ReadLine();
        }
    }
}
