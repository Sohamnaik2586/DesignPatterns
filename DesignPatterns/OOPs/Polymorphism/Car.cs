using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OOPs.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void Start()
        {
            Console.WriteLine("Car is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}
