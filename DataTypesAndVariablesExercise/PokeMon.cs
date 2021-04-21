using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());                //N
            int distance = int.Parse(Console.ReadLine());             //M
            int exhaustion = int.Parse(Console.ReadLine());           //Y

            int target = 0;
            double tempPower = power * 0.5;

            while (power >= distance)
            {
                target++;
                power -= distance;


                if (power == tempPower && exhaustion != 0)
                {
                    power /= exhaustion;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(target);
        }
    }
}
