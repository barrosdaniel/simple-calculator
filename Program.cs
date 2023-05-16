using System;

namespace SimpleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator ===");
            Console.WriteLine("Enter the first operand: ");
            double number_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation [+, -, *, /]: ");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter the second operand: ");
            double number_2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = number_1 + number_2;
                    break;
                case "-":
                    result = number_1 - number_2;
                    break;
                case "*":
                    result = number_1 * number_2;
                    break;
                case "/":
                    result = number_1 / number_2;
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}