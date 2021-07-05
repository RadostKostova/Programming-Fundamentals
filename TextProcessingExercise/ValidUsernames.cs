using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var cur = input[i];

                if (IsValid(cur))
                {
                    Console.WriteLine(cur);
                }
            }
        }

        public static bool IsValid(string current)
        {
            return current.Length >= 3 &&
                   current.Length <= 16 &&
                   current.All(c => char.IsLetterOrDigit(c)) ||
                   current.Contains("-") || current.Contains("_");
        }
    }
}
