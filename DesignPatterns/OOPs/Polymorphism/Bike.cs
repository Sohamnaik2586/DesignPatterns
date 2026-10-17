using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.OOPs.Polymorphism
{
    public class Bike : Vehicle
    {
        public string name { get; set; }
        public string model { get; set; }
        public void Start()
        {
            Console.WriteLine("Bike is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Bike is stopping");
        }

    }
}
