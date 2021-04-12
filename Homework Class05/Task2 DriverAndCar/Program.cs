using System;

namespace Task2_DriverAndCar
{
    class Program
    {
        static int CalcSpeed(int speed, int skill)
        {
            return speed * skill;
        }

        static Driver CheckDriver(Driver[] drivers, string driverSelected)
        {
            foreach (Driver driver in drivers)
            {
                if (driverSelected.ToLower() == driver.DriverName.ToLower()) return driver;
            }
            return null;
        }

        static Car CheckCar(Car[] cars, string carSelected)
        {
            foreach(Car car in cars)
            {
                if (carSelected.ToLower() == car.CarModel.ToLower()) return car;
            }
            return null;
        }

        static void RaceCars(string driver01, string car01, int speed01, int skill01, string driver02, string car02, int speed02, int skill02)
        {
            if (car01 == car02)
            {
                Console.WriteLine("Please choose diferent car from list");
            }
            else if (CalcSpeed(speed01, skill01) > CalcSpeed(speed02, skill02))
            {
                Console.WriteLine($"Car {car01} won over car {car02}. Name of the driver is {driver01} and was driving with a speed of {speed01}km/h.");
            }
            else if (CalcSpeed(speed01, skill01) < CalcSpeed(speed02, skill02))
            {
                Console.WriteLine($"Car {car02} won over car {car01}. Name of the driver is {driver02} and was driving with a speed of {speed02}km/h.");
            }
            else if (CalcSpeed(speed01, skill02) == CalcSpeed(speed02, skill02))
            {
                Console.WriteLine("Try again - Result is equal");
            }
        }


        static void Main(string[] args)
        {
            #region Drivers
            Driver[] drivers = new Driver[]
            {
                new Driver("Zoki", 3),
                new Driver("Koki", 5),
                new Driver("Pero", 10),
                new Driver("Blazo", 4)
            };
            #endregion

            #region Cars

            Car[] cars = new Car[]
            {
                new Car("Bmw", 260),
                new Car("Mercedes", 220),
                new Car("Honda", 240),
                new Car("Opel", 230)
            };
            #endregion

            

            while (true)
            {
                #region First Driver
                Console.WriteLine("Choose from available Car and Driver and test who wins the race:");
                Console.WriteLine("================================================================");
                Console.WriteLine("Choose from list on of driver");

                for (int i = 0; i < drivers.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {drivers[i].DriverName}");
                }
                bool inputCheck = true;
                string firstDriverSelected = "";
                int driver01Skill = 0;

                while (inputCheck)
                {
                    firstDriverSelected = Console.ReadLine();

                    Driver driver1 = CheckDriver(drivers, firstDriverSelected);

                    if (driver1 == null)
                    {
                        Console.WriteLine("Wrong input, try again with name from list");
                        inputCheck = true;
                    }
                    else if (driver1 != null)
                    {
                        Console.WriteLine($"You select driver with Name: {driver1.DriverName}, driver skill level is {driver1.DriverSkill}");
                        firstDriverSelected = driver1.DriverName;
                        driver01Skill = driver1.DriverSkill;
                        inputCheck = false;
                    }
                }
                inputCheck = true;

                #endregion

                #region First Car

                Console.WriteLine("================================================================");
                Console.WriteLine("Choose first car:");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {cars[i].CarModel}");
                }

                string firstCarSelected = "";
                int firstCarSpeed = 0;

                while (inputCheck)
                {
                    firstCarSelected = Console.ReadLine();

                    Car car01 = CheckCar(cars, firstCarSelected);

                    if (car01 == null)
                    {
                        Console.WriteLine("Wrong input, try again with name from list");
                    }
                    if (car01 != null)
                    {
                        inputCheck = false;
                        Console.WriteLine($"Selected car is {car01.CarModel}, and max speed is: {car01.CarSpeed}");
                        firstCarSelected = car01.CarModel;
                        firstCarSpeed = car01.CarSpeed;
                    }

                    
                }
                inputCheck = true;
                #endregion

                #region Second Driver

                Console.WriteLine("================================================================");
                Console.WriteLine("Choose second driver:");
                for (int i = 0; i < drivers.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {drivers[i].DriverName}");
                }

                string secondDriverSelected = "";
                int driver02Skill = 0;

                while (inputCheck)
                {
                    secondDriverSelected = Console.ReadLine();

                    Driver driver2 = CheckDriver(drivers, secondDriverSelected);

                    if (driver2 == null)
                    {
                        Console.WriteLine("Wrong input, try again with name from list");
                        inputCheck = true;
                    }
                    else if (driver2 != null)
                    {
                        Console.WriteLine($"You select driver with Name: {driver2.DriverName}, driver skill level is {driver2.DriverSkill}");
                        secondDriverSelected = driver2.DriverName;
                        driver02Skill = driver2.DriverSkill;
                        inputCheck = false;
                    }
                }
                inputCheck = true;


                #endregion

                #region Second Car

                Console.WriteLine("================================================================");
                Console.WriteLine("Choose second car:");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {cars[i].CarModel}");
                }

                string secondCarSelected = "";
                int secondCarSpeed = 0;

                while (inputCheck)
                {
                    secondCarSelected = Console.ReadLine();

                    Car car02 = CheckCar(cars, secondCarSelected);

                    if ( car02 == null)
                    {
                        Console.WriteLine("Wrong input, try again with name from list");
                    }
                    if ( car02 != null)
                    {
                        inputCheck = false;
                        Console.WriteLine($"Selected car is {car02.CarModel}, and max speed is: {car02.CarSpeed}");
                        secondCarSelected = car02.CarModel;
                        secondCarSpeed = car02.CarSpeed;
                    }
                }
                inputCheck = true;
                #endregion

                Console.WriteLine("You selected two Drivers and two Cars, press any button to see the result");
                
                Console.WriteLine("================================================================");

                RaceCars(firstDriverSelected, firstCarSelected, firstCarSpeed, driver01Skill, secondDriverSelected, secondCarSelected, secondCarSpeed, driver02Skill);

                Console.WriteLine("================================================================");
                Console.WriteLine("If you want to continue with new race press any key, or press Q to exit the program ");

                string exit = Console.ReadLine();

                if ( exit == "q" || exit == "Q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }

                Console.ReadLine();


            }




        }
    }
}
