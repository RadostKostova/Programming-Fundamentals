using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char currSymbol = (char)i;

                Console.Write($"{currSymbol} ");
            }
        }
    }
}
