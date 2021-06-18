using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

            while (pairs-- > 0)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsAndGrades.ContainsKey(studentName) == false)
                {
                    studentsAndGrades.Add(studentName, new List<double>());
                }
                studentsAndGrades[studentName].Add(grade);
            }

            studentsAndGrades = studentsAndGrades
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, studentsAndGrades
                .Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }
}
