﻿using System;

namespace Homework_Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Print the current date with time
            //Print the date that is 10 years from now
            //Print the date that is 2 months and 15 days ago
            //Print day of week for the next 8 - th March
            //Print day of week of last year's Valentine's day

            Console.WriteLine(DateTime.Now.ToString("F"));
            Console.WriteLine(DateTime.Now.AddYears(10).ToString("F"));
            Console.WriteLine(DateTime.Now.AddMonths(-2).AddDays(-15).ToString("F"));
            Console.WriteLine($"Next year 8th of March is: {new DateTime(DateTime.Today.Year + 1, 3, 8).ToString("dddd")}");
            Console.WriteLine($"Last year's 14th February - Valentine's day was on {new DateTime(DateTime.Today.Year - 1, 2, 14).ToString("dddd")}");

            Console.ReadLine();
        }
    }
}
