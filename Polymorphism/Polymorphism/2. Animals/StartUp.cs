﻿using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Peter", "Whiskas");
            Animals dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}