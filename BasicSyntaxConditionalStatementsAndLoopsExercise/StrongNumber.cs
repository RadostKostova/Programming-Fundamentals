using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int copyNum = inputNum;
            int sum = 0;

            while (copyNum != 0)
            {
                int currDigit = copyNum % 10;
                int currFactorial = 1;

                for (int i = 1; i <= currDigit; i++)
                {
                    currFactorial *= i;
                }
                sum += currFactorial;

                copyNum /= 10;
            }

            if (sum == inputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
