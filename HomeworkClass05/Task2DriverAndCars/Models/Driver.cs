using System;
using System.Collections.Generic;
using System.Text;

namespace Task2DriverAndCars
{
    public class Driver
    {
        public Driver()
        {
        }

        public Driver(string name, int skill)
        {
            DriverName = name;
            DriverSkill = skill;
        }

        public string DriverName { get; set; }
        public int DriverSkill { get; set; }
    }
}
