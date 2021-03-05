using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string foodName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double kcalIn100ml = double.Parse(Console.ReadLine());
            double sugarsIn100ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {foodName}:");
            Console.WriteLine($"{((kcalIn100ml * volume) / 100)}kcal, {((sugarsIn100ml * volume) / 100)}g sugars");
        }
    }
}
