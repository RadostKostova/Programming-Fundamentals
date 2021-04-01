using System;

namespace Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            ages = Math.Abs(ages);

            if (ages >= 0 && ages <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (ages >= 3 && ages <= 13)
            {
                Console.WriteLine("child");
            }
            else if (ages >= 14 && ages <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (ages >= 20 && ages <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
