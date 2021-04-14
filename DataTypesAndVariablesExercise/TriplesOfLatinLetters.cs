using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int k = 0; k < input; k++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + k);
                        char third = (char)('a' + j);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
