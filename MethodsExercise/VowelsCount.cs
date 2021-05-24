using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int countVowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol == 'a'
                    || currSymbol == 'o'
                    || currSymbol == 'u'
                    || currSymbol == 'e'
                    || currSymbol == 'i'
                    || currSymbol == 'y')
                {
                    countVowels++;
                }
            }

            GetVowels(countVowels);
            Console.WriteLine(countVowels);
        }

        private static int GetVowels(int countVowels)
        {
            return countVowels; //?
        }
    }
}
