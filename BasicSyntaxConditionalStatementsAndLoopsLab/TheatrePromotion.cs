using System;

namespace TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "weekday":
                        if (0 <= age && age <= 18)
                        {
                            price = 12;
                            Console.WriteLine($"{price}$");
                        }
                        else if (18 < age && age <= 64)
                        {
                            price = 18;
                            Console.WriteLine($"{price}$");
                        }
                        else if (64 < age && age <= 122)
                        {
                            price = 12;
                            Console.WriteLine($"{price}$");
                        }
                        break;
                    case "weekend":
                        if (0 <= age && age <= 18)
                        {
                            price = 15;
                            Console.WriteLine($"{price}$");
                        }
                        else if (18 < age && age <= 64)
                        {
                            price = 20;
                            Console.WriteLine($"{price}$");
                        }
                        else if (64 < age && age <= 122)
                        {
                            price = 15;
                            Console.WriteLine($"{price}$");
                        }
                        break;
                    case "holiday":
                        if (0 <= age && age <= 18)
                        {
                            price = 5;
                            Console.WriteLine($"{price}$");
                        }
                        else if (18 < age && age <= 64)
                        {
                            price = 12;
                            Console.WriteLine($"{price}$");
                        }
                        else if (64 < age && age <= 122)
                        {
                            price = 10;
                            Console.WriteLine($"{price}$");
                        }
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
