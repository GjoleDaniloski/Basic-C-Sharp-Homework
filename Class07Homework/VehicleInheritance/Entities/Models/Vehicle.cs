using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance.Entities.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Vehicle ID: {Id} Manufacturer: {Manufacturer} Model: {Model}");
            
        }
    }
}
