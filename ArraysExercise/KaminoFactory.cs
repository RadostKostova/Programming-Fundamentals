using System;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtSequences = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int counter = 0;
            int bestCount = 0;
            int bestIndex = 0;
            int bestSum = 0;
            string bestSequence = "";
            int bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;

                string bestSubSequence = "";
                counter++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }

                int startIndex = sequence.IndexOf(bestSubSequence);

                if (count > bestCount ||
                    (count == bestCount && startIndex < bestIndex) ||
                    (count == bestCount && startIndex == bestIndex && sum > bestSum) ||
                    counter == 1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestIndex = startIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }

            char[] result = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)} ");
        }
    }
}
