using System;
using System.Collections.Generic;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //For
            int age = 8;
            for (int i = 0; i <= age; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = age; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            //For Each
            int[] numList = { 10, 20, 15 };
            Console.WriteLine("\nForEach");
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }


            var person1 = new Person()
            {
                Name = "Luis Angel",
                LastName = "Quiñones Guerrero",
                Age = 20
            };

            var person2 = new Person()
            {
                Name = "Federico",
                LastName = "Montes Quiñonez",
                Age = 18
            };

            var person3 = new Person()
            {
                Name = "Daniel",
                LastName = "Calvo",
                Age = 20
            };

            var peopleList = new List<Person>();
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);

            foreach (var people in peopleList)
            {
                Console.WriteLine($"\nHello my name is {people.Name} my last name is {people.LastName} and i have {people.Age} years old");
            }
        }
    }

    public class Person
    { 
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
