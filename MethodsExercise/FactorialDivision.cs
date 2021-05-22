using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal first = GetFactorial(firstNumber);
            decimal second = GetFactorial(secondNumber);

            Console.WriteLine($"{first / second:F2}");
        }

        private static decimal GetFactorial(decimal number)
        {
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
