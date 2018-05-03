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
            int size = 1000000;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;
            }

            // Leaner Search  take O(n) : N time
            int searchNumber = 1102;
            int tries = 0;
            for (int j = 0; j < arr.Length; j++)  // n time
            {
                tries++;
                if (searchNumber == arr[j])   //c1 
                {
                    Console.WriteLine("Founded at "+j+" After "+tries+" tries");  //c2
                    break;
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
