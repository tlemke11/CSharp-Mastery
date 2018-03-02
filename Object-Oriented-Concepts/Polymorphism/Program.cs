using System;
using System.Collections.Generic;
using Vehicles;

namespace PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Lambo lambo = new Lambo();
            GeoMetro geometro = new GeoMetro();

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(lambo);
            vehicles.Add(geometro);

            //Here we see PolyMorphism at work, it enables being able to call the honk/revEngine
            //functions on multiple
            foreach (Vehicle car in vehicles)
            {
                Console.WriteLine(car.honk());
                Console.WriteLine(car.revEngine());
            }
        }
    }
}
