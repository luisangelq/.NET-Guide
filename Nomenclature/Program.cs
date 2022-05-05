using System;

namespace Nomenclature
{
    class Program
    {
        public string SumTwoNumbers(int num1, int num2)
        {
            var result = $"Your Numbers are {num1} and {num2}";

            return result;
        }

        //with private we can set _ before 
        private readonly string _thisIsMyString;

        static void Main(string[] args)
        {
            //Camel Case 
            var thisIsCamel = "Cammel";

            //Pascal Case
            var ThisIsPascal = "Pascal";

        }
    }
}
