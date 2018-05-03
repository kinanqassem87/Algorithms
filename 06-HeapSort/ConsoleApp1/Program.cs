using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int total;
        static void Heapfy(int[] arr,int Parentindex)
        {
            int LeftNodeIndex = 2 * Parentindex;
            int RightNodeIndex = 2 * Parentindex + 1;
            int Newindex = Parentindex;
            if (LeftNodeIndex < total && arr[LeftNodeIndex] > arr[Parentindex])
            {
                Newindex = LeftNodeIndex;
            }
            if (RightNodeIndex < total && arr[RightNodeIndex] < arr[Parentindex])
            {
                Newindex = RightNodeIndex;
            }
            if (Newindex != Parentindex)
            {
                swap(arr,  Parentindex, Newindex);
                Heapfy(arr, Newindex);
            }

        }
        static void swap(int[] arr, int  ParentIndex, int  NewIndex)
        {
            int temp = arr[ParentIndex];
            arr[ParentIndex] = arr[NewIndex];
            arr[NewIndex] = temp;
        }

        static void PreSort(int[] arr)    // Big O = n log(n) but better than merge it isn't need more memory
                                          // Best one for sorting...
        {
            
            total = arr.Length - 1;
            for (int i = total/2 ; i >= 0; i--)
            {
                Heapfy(arr, i);
            }
            for (int j = total; j >= 0; j--)
            {
                swap(arr, 0, j);
                total--;
                Heapfy(arr, 0);
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

            PreSort(arr);

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + "\t");
            }
            
            Console.ReadKey();
        }
    }
}
