using System;
using System.Collections;

namespace Queue_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            cola.Enqueue("Hola");
            cola.Enqueue("Mundo");

            //To whatch the value
            var value = cola.Peek();
            // var value2 = cola.Dequeue();

            Console.WriteLine(value);
            // Console.WriteLine(value2);

            //know how many elements
            var count = cola.Count;
            Console.WriteLine(count);
            
            //Clear the queue
            cola.Clear();
            Console.WriteLine(cola.Count); 
            

        }
    }
}
