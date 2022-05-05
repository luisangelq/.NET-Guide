using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //type[] arrayName

            int[] numbersArray;
            int[] numbersArray2 = new int[5];
            int[] numbersArray3 = { 1, 2, 3, 4 };

            //var numbersArray4 = new List<int> { 1, 2, 3, 4 };

            //two dimentions arrays (table)
            int[,] array2D = new int[2, 2];
            int[,] array2D2 = { { 2, 2,5 }, { 3, 6, 6 } };

            for (int i = 0; i < numbersArray3.Length; i++)
            {
                Console.WriteLine(numbersArray3[i]);
            }

            Console.WriteLine("\ntraverse through a 2D array");
            //traverse through a 2D array
            for (int i = 0; i < array2D2.GetLongLength(0); i++)
            {
                for (int y = 0; y < array2D2.GetLongLength(1); y++)
                {
                    Console.WriteLine(array2D2[i, y]);
                }
            }
        }
    }
}
