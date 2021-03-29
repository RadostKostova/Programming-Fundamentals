using System;

namespace MultiplicationTablePt2
{
    class MultiplicationTablePt2
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int sum = 0;

            if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");
                    sum = 0;
                }
            }
        }
    }
}
