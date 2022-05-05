using System;
using static System.Convert;

namespace Data_Type_Convertions
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            var number2 = "20";
            Console.WriteLine(number.ToString());
            Console.WriteLine(Int32.Parse(number2));

            //Impicit
            int wholeNumber = 351245;
            long longNumber = wholeNumber;

            //Explicit 
            double doubleNumber = 12.56;
            int wholeNumberDouble = (int)doubleNumber;
            int wholeNumberDouble2 = ToInt32(doubleNumber);
            Console.WriteLine(wholeNumberDouble2);

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    Console.WriteLine($"{i} is pair and divisible by 3 ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 3 ");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is a Pair Number");
                }
                else {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
