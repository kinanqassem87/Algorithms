using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void QuickSort(int[] arr, int low, int high) // Big n = N^2
        {
            if (low >= high) return;

            int middle = low + (high - low) / 2;
            int pivot = arr[middle];
            int i = low;
            int j = high;
            while (i <= j)
            {
                while (arr[i]<pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
            {
                QuickSort(arr, low, j);
            }
            if (high > i)
            {
                QuickSort(arr, i, high);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 50, 30, 1, 80, 90, 70 };
            Console.WriteLine("Before Sort\n");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + "\t");

            }
            Console.WriteLine("\n\nAfter Sort\n");

            QuickSort(arr, 0, arr.Length - 1);

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + "\t");
            }

            Console.ReadKey();
        }
    }
}
