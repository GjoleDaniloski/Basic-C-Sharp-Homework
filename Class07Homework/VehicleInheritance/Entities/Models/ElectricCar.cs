using System;
using System.Collections.Generic;
using System.Text;
using VehicleInheritance.Entities.Enums;

namespace VehicleInheritance.Entities.Models
{
    public class ElectricCar : Car
    {
        
        
        public int BatteryCapacity;
        public int BatteryUsage;

        public ElectricCar(EngineType typeOfEngine, int fuelConsumption, int numberOfDoors, int maxSpeed, Consumption consumptionLevel, int batteryCapacity, int batteryUsage) 
            : base(typeOfEngine, fuelConsumption, numberOfDoors, maxSpeed, consumptionLevel)
        {
            BatteryCapacity = batteryCapacity;
            BatteryCapacity = batteryUsage;

        }
        public ElectricCar()
        {
        }

        public override void Repair()
        {
            Console.WriteLine($"The {EngineType.Electric} car is repaired and the price for the repair cost 250eur ");
        }

        public void DriveElectricCar(int distance)
        {
            var formula1 = distance * (int)LevelOfConsumption / 10;

            if (BatteryUsage - formula1 < 0)
            {
                Console.WriteLine($"You don't have enough battery, and maximum distance you can passed is: {BatteryUsage / (int)LevelOfConsumption * 10} km");
            }
            else
            {
                BatteryUsage -= formula1;
                Console.WriteLine($"For passed distance of {distance} km, available battery usage is now {BatteryUsage} %");
            }
        }

        public void Recharge(int minutes)
        {
            var formula2 = minutes / 10;
            if (formula2 > BatteryCapacity - BatteryUsage)
            {
                Console.WriteLine($"Can't charge longer that {(BatteryCapacity - BatteryUsage) * 10} minutes");
            }
            else
            {
                BatteryUsage += formula2;
                Console.WriteLine($"You have charged {formula2} % and available battery usage is now {BatteryUsage} %");
            }
        }
    }

    
}
