﻿using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");
                sum = 0;
            }
        }
    }
}
