using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                // we're using Car as reference to Audi and BMW and so the methods that are NOT OVERRIDEN (new) are being called from Car
                new Audi(200, "blue", "a3"),
                new BMW(230, "white", "m3") 
            };

            foreach(var car in cars)
            {
                car.Repair();
                car.showDetails();
                Console.WriteLine(car.Color);
                Console.WriteLine("===========");
            }

            Console.ReadKey();

        }
    }
}
