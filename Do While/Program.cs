using System;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;

            //This runs only if the condition is accomplish
            while (value <= 10)
            {
                Console.WriteLine($"While Time of execution {value}");

                value++;
            }

            //This runs only once before the condition is accomplish
            do
            {
                Console.WriteLine($"\nDo While Time of execution {value}");

                value++;
            } while ( value <= 10 );
        }
    }
}
