using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int input = int.Parse(Console.ReadLine());

                PrintInputXInput(input);
            }

            static void PrintInputXInput(int input)
            {
                for (int row = 0; row < input; row++)
                {
                    for (int col = 0; col < input; col++)
                    {
                        Console.Write(input + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
