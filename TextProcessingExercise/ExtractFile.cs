using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pathFile = Console.ReadLine().Split("\\").ToArray();

            string lastFile = pathFile[pathFile.Length - 1];

            var array = lastFile.Split(".");
            var fileName = array[0];
            var extension = array[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
