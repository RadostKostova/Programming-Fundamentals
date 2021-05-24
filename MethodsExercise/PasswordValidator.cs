using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLong = GetLenght(password);
            bool isLettersAndDigits = GetLettersAndDigits(password);
            bool isLeastTwoDigits = GetDigits(password);

            if (isLong && isLeastTwoDigits && isLettersAndDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool GetDigits(string password)
        {
            int countDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    countDigits++;
                }
            }

            if (countDigits >= 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }

        private static bool GetLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }

        private static bool GetLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }
    }
}
