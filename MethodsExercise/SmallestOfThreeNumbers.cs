using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                int result = GetSmallerNum(a, b, c);
                Console.WriteLine(result);
            }
        }

        private static int GetSmallerNum(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                int result = a;
                return result;
            }
            else if (b < a && b < c)
            {
                int result = b;
                return result;
            }
            else
            {
                int result = c;
                return result;
            }
        }
    }
}
