using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[wagons];

            int sumPassangers = 0;

            for (int i = 0; i < wagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sumPassangers += passangers[i];

            }
            Console.WriteLine(string.Join(' ', passangers));
            Console.WriteLine(sumPassangers);
        }
    }
}
