using System;

namespace Read_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"There are {args.Length} args");
            foreach (var item in args)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
