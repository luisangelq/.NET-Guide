using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var payForm = Console.ReadLine().ToLower();

            switch (payForm)
            {
                case "cash": Console.WriteLine("You pay with Cash");
                    break;
                case "card": Console.WriteLine("You pay with Card");
                    break;
                case "paypal": Console.WriteLine("You pay with Paypal");
                    break;

                default:
                    Console.WriteLine("You are going to pay with cash");
                    break;
            }
        }


    }
}
