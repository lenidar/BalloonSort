using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[100];
            int temp = 0; // used for swapping
            int compCount = 0; // counts the number of comparisons made by the algorithms

            for(int x = 0; x < arr.Length; x++)
                arr[x] = rnd.Next(100);

            // display 
            Console.WriteLine("Displaying unsorted array of numbers...");
            for(int x = 0; x < arr.Length;x++)
            {
                Console.Write(arr[x] + "\t");
                if ((x + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            // Balloon Sort algorithm
            // responsible for dictating the number of passes
            for (int x = 0; x < arr.Length - 1; x++)
            {
                for (int y = x + 1; y < arr.Length; y++)
                {
                    if (arr[x] > arr[y])
                    {
                        temp = arr[x];
                        arr[x] = arr[y];
                        arr[y] = temp;
                    }
                    compCount++;
                }
            }

            // bubble sort
            //for (int x = 0; x < arr.Length; x++)
            //{
            //    for (int y = 0; y < arr.Length - 1; y++)
            //    {
            //        if (arr[y] > arr[y + 1])
            //        {
            //            temp = arr[y];
            //            arr[y] = arr[y + 1];
            //            arr[y + 1] = temp;
            //        }
            //        compCount++;
            //    }
            //}

            // display 2
            Console.WriteLine("Displatying sorted array of numbers...");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x] + "\t");
                if (x > 0 && (x + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Number of comparisons made : {0}", compCount);

            Console.ReadKey();
        }
    }
}
