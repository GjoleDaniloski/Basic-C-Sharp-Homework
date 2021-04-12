using System;
using Task3_Students.Models;

namespace Task3_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[]
            {
                new Students("Filip", "Programming", "5"),
                new Students("Marko", "Design", "2"),
                new Students("Iva", "Digital Marketing", "4"),
                new Students("Milena", "Data Science", "6"),
                new Students("Eva", "Computer Networks", "1")
            };

            while (true)
            {
                Console.WriteLine("Write a student name to see if the student exist:");
                string userInput = Console.ReadLine();
                bool studentCheck = false;

                for (int i = 0; i < students.Length; i++)
                {
                    if (userInput.ToLower() == students[i].Name.ToLower())
                    {
                        Console.WriteLine($"The student {students[i].Name} is learning {students[i].Academy} academy, and is in the {students[i].Group} group");
                        studentCheck = true;
                    }
                }
                if (!studentCheck)
                {
                    Console.WriteLine("No student with that name");
                }

                Console.WriteLine("===========================================");
                Console.WriteLine("Do you want to check for new name? - Press any key Or if you want to close window press Q");
                string exitWindow = Console.ReadLine();
                if (exitWindow == "q")
                {
                    Environment.Exit(0);
                }
            }

            
        }
    }
}
