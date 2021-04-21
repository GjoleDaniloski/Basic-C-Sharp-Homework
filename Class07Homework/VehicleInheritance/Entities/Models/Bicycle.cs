using System;
using System.Collections.Generic;
using System.Text;
using VehicleInheritance.Entities.Enums;

namespace VehicleInheritance.Entities.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }
        public Bicycle()
        {
        }

        public Bicycle(int numberOfSpeedLevels, bool isElectric) : base(WheeledVehicleTypes.Bicycles)
        {
            NumberOfSpeedLevels = numberOfSpeedLevels;
            IsElectric = isElectric;
            Type = WheeledVehicleTypes.Bicycles;
        }
        public void Ride()
        {
            Console.WriteLine($"Let's Go Ride a bike ");
        }
        public override void Repair()
        {
            Console.WriteLine($"The {WheeledVehicleTypes.Bicycles} is repaired and the price for the repair cost 50eur ");
        }
    }
}
