using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program  
    {
        int[] array;
        int[] tempArray;
        static void Main(string[] args)
        {
            int[] arr = { 50, 30, 1, 80, 90, 70 };
            Console.WriteLine("Before Sort\n");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + "\t");

            }
            Console.WriteLine("\n\nAfter Sort\n");

            new Program().prapareForSort(arr);

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + "\t");

            }
            
            

            Console.ReadKey();
        }
        void prapareForSort(int[] arr)
        {
            //Preaper for sorting
            this.array = arr;
            this.tempArray = new int[arr.Length];
            DoMergeSort(0, arr.Length - 1);
        }
        //Divide into small problem
        void DoMergeSort(int LowerIndex,int HigherIndex)
        {
            if (LowerIndex < HigherIndex)
            {
                int middle = LowerIndex + (HigherIndex - LowerIndex) / 2;
                DoMergeSort(LowerIndex, middle);
                DoMergeSort(middle + 1, HigherIndex);
                mergePart(LowerIndex, middle, HigherIndex);
            }
        }
        // Merge small problem and sort
        void mergePart(int lowerindex, int middle, int higherindex)  //Big O = n*log(n)
        {
            for (int i = lowerindex; i <= higherindex; i++)
            {
                tempArray[i] = array[i];
            }
            int ii = lowerindex;
            int j = middle + 1;
            int k = lowerindex;
            while (ii <= middle && j <= higherindex)
            {
                if (tempArray[ii] < tempArray[j])
                {
                    array[k] = tempArray[ii];
                    ii++;
                }
                else
                {
                    array[k] = tempArray[j];
                    j++;
                }
                k++;

            }
            while (ii <= middle)
            {
                array[k] = tempArray[ii];
                k++;
                ii++;
            }
        }
    }
}
