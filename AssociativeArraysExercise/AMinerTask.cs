using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> output = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!output.ContainsKey(resource))
                {
                    output.Add(resource, 0);
                }
                output[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
