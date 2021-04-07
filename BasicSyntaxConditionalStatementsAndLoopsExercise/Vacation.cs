using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int groupNumber = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalprice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        totalprice = groupNumber * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        totalprice = groupNumber * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        totalprice = groupNumber * 10.46;
                    }
                    break;

                case "Business":
                    if (day == "Friday")
                    {
                        if (groupNumber >= 100)
                        {
                            totalprice = (groupNumber - 10) * 10.90;
                        }
                        else
                        {
                            totalprice = groupNumber * 10.90;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (groupNumber >= 100)
                        {
                            totalprice = (groupNumber - 10) * 15.60;
                        }
                        else
                        {
                            totalprice = groupNumber * 15.60;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (groupNumber >= 100)
                        {
                            totalprice = (groupNumber - 10) * 16;
                        }
                        else
                        {
                            totalprice = groupNumber * 16;
                        }
                    }
                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        totalprice = groupNumber * 15;
                    }
                    else if (day == "Saturday")
                    {
                        totalprice = groupNumber * 20;
                    }
                    else if (day == "Sunday")
                    {
                        totalprice = groupNumber * 22.50;
                    }
                    break;
            }

            if (typeOfGroup == "Students" && groupNumber >= 30)
            {
                totalprice = totalprice - (totalprice * 0.15);
            }
            else if (typeOfGroup == "Regular" && groupNumber >= 10 && groupNumber <= 20)
            {
                totalprice = totalprice - (totalprice * 0.05);
            }
            Console.WriteLine($"Total price: {totalprice:f2}");
        }
    }
}
