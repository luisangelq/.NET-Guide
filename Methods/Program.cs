using System;

namespace Methods_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = Name("Luis", "Quiñones");
            Console.WriteLine(fullName);

            MethodWithParams("Angel", "Guerrero");
        }


        //Method that only executes code
        public static void Method()
        {
            Console.WriteLine("Im executing");
        }

        public static void MethodWithParams(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);

        }

        //Function that returns something without params
        public static int FunctionWithoutParams()
        {
            return 0;
        }

        //Function that returns something with params
        public static string Name(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

    }
}
