using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArgs[1]));
                }
                else
                {
                    int passangers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];
                        bool isEnoughSpace = (currWagon + passangers) <= capacity;

                        if (isEnoughSpace)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
