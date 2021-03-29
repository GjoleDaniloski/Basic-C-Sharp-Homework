using System;

namespace Homework_Class02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("========= Task 1 =========");

            int num1 = 0; int num2 = 0;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose operator: +, - , * , / ");
            Console.WriteLine("\t+ addition");
            Console.WriteLine("\t- subtraction");
            Console.WriteLine("\t* multiplication");
            Console.WriteLine("\t/ division");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


            #endregion

            #region Task 2

            Console.WriteLine("========= Task 2 =========");

            int number1, number2, number3, number4, average;

            Console.WriteLine("Enter the First number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number");
            number4 = Convert.ToInt32(Console.ReadLine());

            average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is: " + average);

            #endregion

            #region Task 3

            Console.WriteLine("========= Task 3 =========");

            int input1, input2, temp;

            Console.WriteLine("Input the First Number");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number");
            input2 = Convert.ToInt32(Console.ReadLine());

            temp = input1;
            input1 = input2;
            input2 = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First Number: " + input1);
            Console.WriteLine("Second Number: " + input2);

            #endregion

            #region Task 4

            Console.WriteLine("========= Task 4 =========");

            int numberInput = 0;

            Console.WriteLine("Enter a number to check if it is divisible by 3 and 5");
            Console.WriteLine("And it will return: TIK if divisible by 3, TAK if divisible by 5 and TIK - TAK if divisible by 3 and 5 ");

            bool parseCheck = int.TryParse(Console.ReadLine(), out numberInput);

            if (parseCheck)
            {
                if (numberInput % 3 == 0)
                {
                    Console.WriteLine("Tik");

                    if (numberInput % 5 == 0)
                    {
                        Console.WriteLine(" - Tak");
                    }
                }
                else if (numberInput % 5 == 0)
                {
                    Console.WriteLine("Tak");
                }

                else
                {
                    Console.WriteLine("Bad number");
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
