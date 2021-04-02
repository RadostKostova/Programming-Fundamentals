using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 0; i < 3; i++)
            {
                string inputPassword = Console.ReadLine();

                if (password == inputPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            string lastTryPassword = Console.ReadLine();

            if (lastTryPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
