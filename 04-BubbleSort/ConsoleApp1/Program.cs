using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void BubbleFun(int[] arr)   //  big O = O(n^2)
        {
            int n = arr.Length;
            int temp = 0;
            for (int i = 0; i < n; i++)  // n time
            {
                for (int j = 1; j < n - i; j++)  // n time
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j-1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 50, 30, 1, 80, 90, 70 };
            Console.WriteLine("Before Sort\n");
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.Write(arr[i]+"\t");

            }
            Console.WriteLine("\n\nAfter Sort\n");
            for (int j = 0; j < arr.Length; j++)
            {
                
                BubbleFun(arr);
                Console.Write(arr[j]+"\t");

            }
            Console.ReadKey();

        }
    }
}
