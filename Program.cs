using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            string operation;

            Console.WriteLine("Hello, welcome to the calculator");

            Console.WriteLine("Please enter the first number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What kind of operation would you like?");
            Console.WriteLine("Please enter a for addition, s for substraction, m for multiplication, or d for division");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "a":
                    Console.WriteLine($"The result is: {num1 + num2}");
                    break;
                case "s":
                    Console.WriteLine($"The result is: {num1 - num2}");
                    break;
                case "m":
                    Console.WriteLine($"The result is: {num1 * num2}");
                    break;
                case "d":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"The result is: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            Console.WriteLine("Thanks for using my calculator");
        }
    }
}
