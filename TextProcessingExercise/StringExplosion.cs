using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string field = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < field.Length; i++)
            {
                char currChar = field[i];

                if (currChar == '>')
                {
                    bomb += int.Parse(field[i + 1].ToString());
                    continue;
                }

                if (bomb > 0)
                {
                    field = field.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }

            Console.WriteLine(field);
        }
    }
}
