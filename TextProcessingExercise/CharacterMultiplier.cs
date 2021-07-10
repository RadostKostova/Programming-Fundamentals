using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string first = tokens[0];
            string second = tokens[1];

            var longestWord = first;
            var shortestWord = second;

            if (first.Length < second.Length)
            {
                longestWord = second;
                shortestWord = first;
            }

            var total = CharManipulator(longestWord, shortestWord);
            Console.WriteLine(total);
        }

        public static int CharManipulator(string longestWord, string shortestWord)
        {
            var sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                var multiply = longestWord[i] * shortestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }
            return sum;
        }
    }
}
