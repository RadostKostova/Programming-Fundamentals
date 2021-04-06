using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double ivanChoMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double additionalSabers = Math.Ceiling(students * 0.10);
            double allSabers = lightsaberPrice * (students + additionalSabers);
            double allRobes = students * robePrice;

            double freeBelts = 0;

            for (int i = 6; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double allBelts = (students - freeBelts) * beltPrice;
            double totalPrice = allSabers + allRobes + allBelts;

            if (ivanChoMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - ivanChoMoney):f2}lv more.");
            }
        }
    }
}
