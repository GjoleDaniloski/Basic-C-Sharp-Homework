using System;

namespace Homework_Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework Exercise from Class

            Console.WriteLine("============= Create an array with names =============");

            string[] arrayNames = new string[]
            {
                "Zoran",
                "Rajko",
                "Petko",
                "Trajko",
                "Pero"
            };

            Console.WriteLine("Default list with element in Array");
            Console.WriteLine("===========================");
            foreach (string student in arrayNames)
            {
                Console.WriteLine(student);
            }

            do
            {
                while (true)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("Add Name: ");
                    string name = Console.ReadLine();
                    Array.Resize(ref arrayNames, arrayNames.Length + 1);
                    arrayNames[arrayNames.Length - 1] = name;
                    Console.WriteLine("If you want to continue press Y or to close the program press N");



                    string exitProgram = Console.ReadLine();
                    if (exitProgram == "N" || exitProgram == "n") break;
                    else continue;

                }
                Console.WriteLine("===========================");
                Console.WriteLine("List with new element in Array");
                foreach (string name in arrayNames)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("===========================");

                Console.WriteLine("Write again N and exit from program or if you want to add another name press Y");

                string continueProgram = Console.ReadLine();
                if (continueProgram == "Y" || continueProgram == "y") continue;
                else break;
            } while (true);

            #endregion

            #region Homework Task 1

            Console.WriteLine("============= Console application Student Group =============");

            int[] arrayNumbers = new int[6];
            int sumEven = 0;

            Console.WriteLine("Enter 6 number and you receive sum only from even number");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.WriteLine("Enter integer no." + (i + 1));
                bool isValidNumber = int.TryParse(Console.ReadLine(), out arrayNumbers[i]);
                if (isValidNumber)
                {
                    if (arrayNumbers[i] % 2 == 0) sumEven += arrayNumbers[i];
                    else continue;
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                    i--;
                    continue;
                }
            }

            Console.WriteLine("The sum of all even number you write is: " + sumEven);

            #endregion

            #region Homework Task 2

            Console.WriteLine("============= Application Student Group =============");

            string[] studentsG1 = new string[]
            {
                "Gjorgje",
                "Ivan",
                "Nikola",
                "Leart",
                "Gligor"
            };

            string[] studentsG2 = new string[]
            {
                "Jana",
                "Sanja",
                "Ceca",
                "Marta",
                "Jelena"
            };



            Console.WriteLine("Choose between: 1 or 2 to see Students in First and Second Group");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("The student in G1 are:");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case "2":
                    Console.WriteLine("The student in G2 are:");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            #endregion


            Console.ReadLine();
        }
    }
}
