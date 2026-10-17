using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.OOPs.Polymorphism
{
    public class Vehicle
    {
        public string Name { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    }
}
