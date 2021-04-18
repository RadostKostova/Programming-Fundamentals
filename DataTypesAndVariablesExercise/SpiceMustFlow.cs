using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYeald = int.Parse(Console.ReadLine());
            int spicesMined = 0;
            int dropdownYeald = 10;
            int workersConsumer = 26;
            int days = 0;

            while (startYeald >= 100)
            {
                spicesMined += startYeald;
                spicesMined -= workersConsumer;
                startYeald -= dropdownYeald;
                days++;
            }

            if (spicesMined != 0)
            {
                spicesMined -= workersConsumer;
            }

            Console.WriteLine(days);
            Console.WriteLine(spicesMined);
        }
    }
}
