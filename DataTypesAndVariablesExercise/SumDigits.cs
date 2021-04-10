using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = (int)char.GetNumericValue(input[i]);

                sum += currNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
