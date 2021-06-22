using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] cmdArgs = input.Split("-");
                string user = cmdArgs[0];

                if (cmdArgs.Length > 2)
                {
                    //: "{username}-{language}-{points}"
                    string language = cmdArgs[1];
                    int points = int.Parse(cmdArgs[2]);

                    if (students.ContainsKey(user) == false)
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }

                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    students.Remove(user);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (var currStudent in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currStudent.Key} | {currStudent.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var currSubmission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currSubmission.Key} - {currSubmission.Value}");
            }
        }
    }
}
