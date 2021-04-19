using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int waterTank = 0;

            int capacity = 255;

            for (int i = 0; i < numberOfLines; i++)
            {
                int litresToPour = int.Parse(Console.ReadLine());

                if (waterTank + litresToPour <= capacity)
                {
                    waterTank += litresToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(waterTank);
        }
    }
}
