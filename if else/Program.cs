using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else
            string flag = "blue";

            if (flag == "Red")
            {
                Console.WriteLine($"The color Flag is: Red");
            }
            else 
            {
                Console.WriteLine($"The Color Flag is: {flag}");
            }
        }
    }
}
