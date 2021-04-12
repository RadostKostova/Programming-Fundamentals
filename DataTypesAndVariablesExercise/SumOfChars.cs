using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalChars = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < totalChars; i++)
            {
                int symbol = char.Parse(Console.ReadLine());

                sum += symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
