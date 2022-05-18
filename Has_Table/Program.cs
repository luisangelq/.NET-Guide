using System;
using System.Collections;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hastable = new Hashtable();
            hastable.Add("Luis", 21);
            hastable.Add("Juan", 22);
            hastable.Add("Pedro", 23);

            //traverse the hastable
            foreach (DictionaryEntry entry in hastable)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            //Get the value of a key
            Console.WriteLine($"Edad de Luis es {hastable["Luis"]} años");

            var algo = hastable.Keys;

            foreach (var entry in algo)
            {
                Console.WriteLine(entry);
            }






        }
    }
}
