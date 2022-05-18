using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Luis");

            list.Insert(2, "inserted");

            //list.RemoveAt(list.Count - 1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            int counter = list.Count;
            Console.WriteLine(counter);


        }
    }
}
