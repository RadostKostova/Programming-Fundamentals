using System;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hourInput = int.Parse(Console.ReadLine());
            int minuteInput = int.Parse(Console.ReadLine());

            minuteInput += 30;

            if (minuteInput > 59)
            {
                hourInput++;
                minuteInput -= 60;
            }

            if (hourInput > 23)
            {
                hourInput = 0;
            }

            Console.WriteLine($"{hourInput:D1}:{minuteInput:D2}");
        }
    }
}
