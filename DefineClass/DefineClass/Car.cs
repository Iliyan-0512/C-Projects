﻿using System;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        static void Main(string[] args)
        {
           Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            Console.WriteLine($"Make is {car.Make}");
        }
    }
}