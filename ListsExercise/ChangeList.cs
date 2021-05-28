using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string firstCommand = cmdArgs[0];
                int element = int.Parse(cmdArgs[1]);

                if (firstCommand == "Delete")
                {
                    list.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    list.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
