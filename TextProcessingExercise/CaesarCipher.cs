using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char item in input)
            {
                var currChar = (char)(item + 3);
                Console.Write(currChar);
            }
        }
    }
}
