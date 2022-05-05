using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string greet = null;


            int age = default(int); // 0
            int? heigth = null; // with ? we can assign null to a variable
            bool access = default(bool); // false

            DateTime? recentDate = null;


            Console.WriteLine(age);
            Console.WriteLine(heigth);
            Console.WriteLine(access);
            Console.WriteLine(recentDate);
            Console.WriteLine(message);
            Console.ReadKey();

            var variable = "Variable var " + 5;
            Console.WriteLine(variable);



        }
    }
}
