﻿using System;

namespace Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dog dog= new Dog();
            dog.Bark();
            dog.Eat();

           Cat cat= new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}