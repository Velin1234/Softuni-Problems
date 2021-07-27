using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool Valid = true;

            Valid = CheckLength(password, Valid);
            Valid = OnlyLettersAndDigits(password, Valid);
            Valid = CheckFor2Digits(password, Valid);

            if (Valid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckFor2Digits(string password, bool Valid)
        {
            int digitCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    digitCount++;
                }
            }

            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                Valid = false;
            }
            return Valid;
        }

        private static bool OnlyLettersAndDigits(string password, bool Valid)
        {
            bool localValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    localValid = false;
                }
            }

            if (!localValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                Valid = false;
            }

            return Valid;
        }

        private static bool CheckLength(string password, bool Valid)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                Valid = false;
            }

            return Valid;
        }
    }
}
