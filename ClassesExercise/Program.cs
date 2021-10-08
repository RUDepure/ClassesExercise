using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();

            firstCar.Make = "Honda";
            firstCar.Model = "Civic";
            firstCar.Year = 2016;

            Console.WriteLine($"My first car is a {firstCar.Make} {firstCar.Model} {firstCar.Year}");
        }
    }
}
