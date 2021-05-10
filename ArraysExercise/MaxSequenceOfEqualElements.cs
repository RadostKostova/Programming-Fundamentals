using System;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console
                .ReadLine()
                .Split(" ");

            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string currElement = array[i];
                int currCount = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currElement == array[j])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }
        }
    }
}
