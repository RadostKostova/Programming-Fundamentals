using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (occurences.ContainsKey(letter) == false)
                    {
                        occurences.Add(letter, 0);
                    }
                    occurences[letter]++;
                }
            }

            foreach (var chars in occurences)
            {
                char currKey = chars.Key;
                int currValue = chars.Value;

                Console.WriteLine($"{currKey} -> {currValue}");
            }
        }
    }
}
