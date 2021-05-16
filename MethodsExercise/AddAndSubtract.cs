using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SumResult(num1, num2, num3));
        }

        private static int SumResult(int num1, int num2, int num3)
        {
            int sum = num1 + num2;
            sum -= num3;

            return sum;
        }
    }
}
