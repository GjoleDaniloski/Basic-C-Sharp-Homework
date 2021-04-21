using System;
using System.Collections.Generic;
using System.Text;
using VehicleInheritance.Entities.Enums;

namespace VehicleInheritance.Entities.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public WheeledVehicleTypes Type { get; set; }

        public WheeledVehicle()
        {
        }
        public WheeledVehicle(WheeledVehicleTypes type) 
        {
            Type = type;
        }

        public virtual void Repair()
        {
            Console.WriteLine("Your vehicle has been repaired");
        }
    }
}
