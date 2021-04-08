using System;

namespace RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalCost = 0;

            for (int i = 2; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalCost += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    totalCost += mousePrice;
                }

                if (i % 6 == 0)
                {
                    totalCost += keyboardPrice;
                    if (i % 12 == 0)
                    {
                        totalCost += displayPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}
