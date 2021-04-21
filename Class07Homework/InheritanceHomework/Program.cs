using System;
using VehicleInheritance.Entities.Enums;
using VehicleInheritance.Entities.Models;

namespace InheritanceHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("================ Vehicles ================");
            Console.WriteLine("=================== Car ==================");

            Car porsche = new Car()
            {
                Id = 1,
                Manufacturer = "Porsche",
                Model = "Panamera 4S",
                NumberOfDoors = 5,
                NumberOfWheels = 4,
                MaxSpeed = 295,
                FuelConsumption = 10,
                TypeOfEngine = EngineType.Diesel
            };

            porsche.PrintInfo();
            porsche.Drive();
            porsche.Repair();

            Console.WriteLine("==========================================");
            Console.WriteLine("================ Electric Car ============");

            ElectricCar tesla = new ElectricCar()
            {
                Id = 2,
                Manufacturer = "Tesla",
                Model = "Newest",
                NumberOfDoors = 5,
                NumberOfWheels = 4,
                MaxSpeed = 220,
                TypeOfEngine = EngineType.Electric,
                LevelOfConsumption = Consumption.economic,
                BatteryCapacity = 100,
                BatteryUsage = 80


            };

            tesla.PrintInfo();
            tesla.DriveElectricCar(300);
            tesla.Recharge(300);
            tesla.Repair();

            Console.WriteLine("==========================================");
            Console.WriteLine("================ Bicycle ============");

            Bicycle corratec = new Bicycle()
            {
                Id = 3,
                Manufacturer = "Corratec",
                Model = "X Vert 29 Elite",
                NumberOfWheels = 2
                
            };

            corratec.PrintInfo();
            corratec.Ride();
            corratec.Repair();

            Console.ReadLine();
        }
    }
}
