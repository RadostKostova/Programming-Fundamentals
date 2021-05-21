using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 == 1)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2 - 1]}{input[input.Length / 2]}");
            }
        }
    }
}
