using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalKegs = int.Parse(Console.ReadLine());
            string model = string.Empty;

            double kegInfo = 0;

            for (int i = 0; i < totalKegs; i++)
            {
                string currModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currKegInfo = Math.PI * Math.Pow(radius, 2) * height;

                if (currKegInfo > kegInfo)
                {
                    kegInfo = currKegInfo;
                    model = currModel;
                }
            }
            Console.WriteLine(model);
        }
    }
}
