using System;
using System.Collections.Generic;
using System.Text;
using VehicleInheritance.Entities.Enums;

namespace VehicleInheritance.Entities.Models
{
    public class Car : WheeledVehicle
    {
        public EngineType TypeOfEngine { get; set; }
        public WheeledVehicleTypes WeeledVehicle { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public Consumption LevelOfConsumption { get; set; }
        public Car()
        {
        }
        public Car(EngineType typeOfEngine, int fuelConsumption, int numberOfDoors, int maxSpeed, Consumption consumptionLevel) : base(WheeledVehicleTypes.Cars)
        {
            TypeOfEngine = typeOfEngine;
            FuelConsumption = fuelConsumption;
            NumberOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
            WeeledVehicle = WheeledVehicleTypes.Cars;
            LevelOfConsumption = consumptionLevel;
        }
        
        public virtual void Drive()
        {
            Console.WriteLine($"The {Model} is driving and maximum speed is {MaxSpeed}km/h");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Manufacturer} {Model} is repaired and the cost of the repair is 400eur ");
        }

    }
}
