using System;
using System.Linq;

namespace ArrayRotation
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

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int temp = array[0];

                for (int index = 0; index < array.Length - 1; index++)
                {
                    array[index] = array[index + 1];
                }

                array[array.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
