using System;

namespace StudentInformation
{
    class StudentInformation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            string output = string.Format($"Name: {name}, Age: {age}, Grade: {grade:f2}");
            Console.WriteLine(output);
        }
    }
}
