using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char sym1 = char.Parse(Console.ReadLine());
            char sym2 = char.Parse(Console.ReadLine());

            PrintBetweenSymbols(sym1, sym2);
        }

        private static void PrintBetweenSymbols(char start, char end)
        {
            if (start > end)
            {
                for (int i = ++end; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = ++start; i < end; i++)
                {
                    Console.Write((char)i + " ");
                };
            }
        }
    }
}
