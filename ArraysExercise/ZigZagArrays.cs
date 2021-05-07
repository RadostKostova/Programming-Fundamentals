using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            string[] firstArr = new string[numbers];
            string[] secondArr = new string[numbers];

            for (int i = 0; i < numbers; i++)
            {
                string[] currArr = Console.ReadLine().Split(" ").ToArray();

                string zeroElement = currArr[0];
                string oneElement = currArr[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = zeroElement;
                    secondArr[i] = oneElement;
                }
                else
                {
                    firstArr[i] = oneElement;
                    secondArr[i] = zeroElement;
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
