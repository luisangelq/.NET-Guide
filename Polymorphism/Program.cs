using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.MakeSound();
            dog.MakeSound();

            List<Animal> zoo = new List<Animal>();
            zoo.Add(cat);
            zoo.Add(dog);

            foreach (var item in zoo)
            {
                item.MakeSound();
            }
        }
    }
}
