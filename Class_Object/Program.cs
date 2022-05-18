using System;

namespace Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account bank_Account = new Bank_Account();
            Bank_Account bank_Account1 = new Bank_Account();

            bank_Account.Balance = 2000;
            bank_Account1.Balance = 3000;

            int sum = bank_Account.Balance + bank_Account1.Balance;

            Console.WriteLine(sum);
        }
    }
}
