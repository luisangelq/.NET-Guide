using System;
using System.Collections;

namespace Stack_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            pila.Push(10);
            pila.Push(20);
            pila.Push(35);
            pila.Push(45);

            object num = pila.Pop();
            Console.WriteLine(num);

            Console.WriteLine(pila.Count);

            //pila.Clear();

        }
    }
}
