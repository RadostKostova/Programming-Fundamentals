using System;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:d4} {secNum:d4} {thirdNum:d4} {fourthNum:d4}");
        }
    }
}
