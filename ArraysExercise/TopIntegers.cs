using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currNumber = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    int otherNumber = array[j];

                    if (currNumber <= otherNumber)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNumber + " ");
                }
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}
