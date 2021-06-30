using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfPeople = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictOfNames = new Dictionary<string, int>();

            foreach (var name in listOfPeople)
            {
                dictOfNames.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-z]"; //[\WA-Za-z]

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");
                int sum = 0;

                foreach (var digit in distance)
                {
                    int currDigit = int.Parse(digit.ToString());
                    sum += currDigit;
                }

                if (dictOfNames.ContainsKey(name))
                {
                    dictOfNames[name] += sum;
                }
                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var kvp in dictOfNames.OrderByDescending(x => x.Value))
            {
                string output = string.Empty;
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {kvp.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
