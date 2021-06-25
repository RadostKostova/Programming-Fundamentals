using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var userPlateNumber = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandsArgs = Console.ReadLine().Split();

                string command = commandsArgs[0];
                string name = commandsArgs[1];

                if (command == "register")
                {
                    string plateNum = commandsArgs[2];

                    if (!userPlateNumber.ContainsKey(name))
                    {
                        userPlateNumber[name] = plateNum;

                        Console.WriteLine($"{name} registered {plateNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNum}");
                    }
                }
                else
                {
                    if (!userPlateNumber.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        userPlateNumber.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            string output = "{0} => {1}";

            Console.WriteLine(string.Join(Environment.NewLine, userPlateNumber.Select(x => string.Format(output, x.Key, x.Value))));
        }
    }
}
