using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Bill", "Smith", 41, 'M'),
                new Person("Sarah", "Jones", 22, 'F'),
                new Person("Stacy", "Baker", 21, 'F'),
                new Person("Vivianne", "Dexter", 19, 'F'),
                new Person("Bob", "Smith", 49, 'M'),
                new Person("Brett", "Baker", 51, 'M'),
                new Person("Mark", "Parker", 19, 'M'),
                new Person("Alice", "Thompson", 18, 'F'),
                new Person("Evelyn","Thompson", 58, 'F' ),
                new Person("Mort","Martin", 58, 'M'),
                new Person("Eugene","deLauter", 84, 'M' ),
                new Person("Gail","Dawson", 19, 'F' ),
            };

            // Task 01
            // all people aged 50 or more
            Console.WriteLine("===================== Task 01 =====================");
            Console.WriteLine("List of All People with age of 50 or more");
            List<Person> peopleAged50 = people
                                .Where(x => x.Age >= 50)
                                .ToList();
            peopleAged50.ForEach(x => Console.WriteLine($"Person: Name: {x.FirstName} Surname: {x.LastName} with Age: {x.Age}"));

            // Task 02
            // all people name starts with B
            Console.WriteLine("===================== Task 02 =====================");
            Console.WriteLine("List of All People name starts with B");
            List<Person> nameStartWithB = people
                                      .Where(x => x.FirstName.StartsWith("B"))
                                      .ToList();
            nameStartWithB.ForEach(x => Console.WriteLine(x.FirstName));

            // Task 03
            // first person whose surname starts with T
            Console.WriteLine("===================== Task 03 =====================");
            Console.WriteLine("First person whose surname starts with T");
            List<Person> firstPersonSurnameStartWithT = people
                                                        .Where(x => x.LastName.StartsWith("T"))
                                                        .ToList();
            firstPersonSurnameStartWithT.ForEach(x => Console.WriteLine($"Persons who surname start with T is: {x.FirstName} {x.LastName} "));

            // Task 04
            // find youngest and oldest person
            Console.WriteLine("===================== Task 04 =====================");
            Console.WriteLine("Find youngest and oldest person");
            Person youngestPerson = people
                                       .Where(x => x.Age == people.Select(x => x.Age).Min())
                                       .FirstOrDefault();

            Person oldestPerson = people
                                       .Where(x => x.Age == people.Select(x => x.Age).Max())
                                       .FirstOrDefault();


            Console.WriteLine($"Youngest Person is: {youngestPerson.FirstName} {youngestPerson.LastName} with {youngestPerson.Age} ages.");
            Console.WriteLine($"Oldest Person is: {oldestPerson.FirstName} {oldestPerson.LastName} with {oldestPerson.Age} ages.");

            // Task 05
            // find all male people aged 45 or more
            Console.WriteLine("===================== Task 05 =====================");
            Console.WriteLine("Find all male people aged 45 or more");
            List<Person> malePeopleAged45 = people
                                            .Where(x => x.Gender == 'M')
                                            .Where(x => x.Age > 45)
                                            .ToList();
            malePeopleAged45.ForEach(x => Console.WriteLine($"Person: {x.FirstName} {x.LastName} with {x.Age} ages."));


            // Task 06
            // find all females whose name starts with V
            Console.WriteLine("===================== Task 06 =====================");
            Console.WriteLine("Find all females whose name starts with V");
            List<Person> femaleNameStartWithV = people
                                                .Where(x => x.Gender == 'F')
                                                .Where(x => x.FirstName.StartsWith('V'))
                                                .ToList();
            femaleNameStartWithV.ForEach(x => Console.WriteLine($"All females with name who start with V: \n{x.FirstName}"));

            // Task 07
            // find last female person older than 30 whose name starts with p
            Console.WriteLine("===================== Task 07 =====================");
            Console.WriteLine("Find last female person older than 30 whose name starts with p");
            Person lastFemalePersonOlder30 = people
                                             .Where(x => x.Gender == 'F')
                                             .Where(x => x.Age > 30 && x.FirstName.StartsWith('P'))
                                             .LastOrDefault();
            Console.WriteLine(lastFemalePersonOlder30 != null ? $"Last female person older than 30 whose name start with p{lastFemalePersonOlder30.FirstName}{lastFemalePersonOlder30.LastName}" : $"Sorry - Person with that information is not found ");

            // Task 08
            // find first male younger than 40
            Console.WriteLine("===================== Task 08 =====================");
            Console.WriteLine("Find first male younger than 40");
            Person firstMaleYounger40 = people
                                        .Where(x => x.Gender == 'M' && x.Age < 40)
                                        .FirstOrDefault();
            Console.WriteLine(firstMaleYounger40 == null ? $"Sorry - Person with that information is not found" : $"We found this person who is younger than 40 - Person: {firstMaleYounger40.FirstName} {firstMaleYounger40.LastName} with {firstMaleYounger40.Age} age.");


            // Task 09
            // print the names of the male persons that have firstName longer than lastName
            Console.WriteLine("===================== Task 09 =====================");
            Console.WriteLine("Print the names of the male persons that have firstName longer than lastName");
            List<Person> fNameLongerlName = people
                                            .Where(x => x.FirstName.Length > x.LastName.Length)
                                            .ToList();
            fNameLongerlName.ForEach(x => Console.WriteLine($"Person who first name is longer than last name is:\nPerson: {x.FirstName} {x.LastName}"));


            // Task 10 - NE MI BESE TUKA JASNO DALI TREBA I .Select DA GO STAVAM ZA LASTNAME
            // print the lastNames of the female persons that have odd number of ages
            Console.WriteLine("===================== Task 10 =====================");
            Console.WriteLine("Print the lastNames of the female persons that have odd number of ages");
            List<Person> lNameFemaleOddAges = people
                                              .Where(x => x.Gender == 'F' && x.Age % 2 == 1)
                                              .ToList();
            lNameFemaleOddAges.ForEach(x => Console.WriteLine($"Last names of female person with odd number of age is:\nPerson: {x.FirstName} {x.LastName} - {x.Age}"));
                                              


            Console.ReadLine();
        }
    }
}
