using System;

namespace PassByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            //JustPassingValue(age);

            ChangeVariableByRef(ref age);

            Console.WriteLine(age);


        }

        public static void JustPassingValue(int age)
        {
            age += 10;
        }

        public static void ChangeVariableByRef(ref int age)
        {
            age -= 10;
        }
    }
}
