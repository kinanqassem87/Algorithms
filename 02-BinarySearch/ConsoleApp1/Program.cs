using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 1000;
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            //Binary Search     Time Log(n) becuase tries double or decrease to middle
            // Use when array is orderd
            int searchNumber = 1;
            int low = 0;
            int high = arr.Length-1;
            int mid = 0;
            bool isfounded = false;
            int tries = 0;
            while (!isfounded)
            {
                tries++;
                mid = low + (high - low) / 2;
                if (searchNumber == arr[mid]) { isfounded = true; break; }

                if (searchNumber > arr[mid])
                {
                    low = mid + 1;
                }

                if (searchNumber < arr[mid])
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine("Founded is " + isfounded+" after :"+tries);


            /*
             * Second way...
             * 
            int mid =0;
            bool founded = false;
            while (low <= high)
            {

                mid = low + (high - low) / 2;

                if (searchNumber == arr[mid]) { founded = true;  break; }
                else if (searchNumber > arr[mid])
                {
                    low = mid + 1;
                    
                }
                else if (searchNumber < arr[mid])
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine("Founded is " + founded);
            */
            Console.ReadKey();
        }
    }
}
