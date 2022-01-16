using System;

namespace Password_strength_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!#?-";

            Console.WriteLine("Enter your password: ");
            string userInput = Console.ReadLine();

            int score = 0;

            if (userInput.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(userInput, uppercase))
            {
                score++;
            }

            if (Tools.Contains(userInput, lowercase))
            {
                score++;
            }

            if (Tools.Contains(userInput, digits))
            {
                score++;
            }

            if (Tools.Contains(userInput, specialChars))
            {
                score++;
            }

            Console.WriteLine($"Strength of password is {score} out of 5");

            switch (score)
            {
                case 5:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("The password is strong");
                    break;
                case 2:
                    Console.WriteLine("The password is medium");
                    break;
                case 1:
                    Console.WriteLine("The password is weak");
                    break;
                default:
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
            }
            Console.WriteLine("  ");
            Console.WriteLine("Your password is not sent to any locations, it is just estimated in this app.");
        }
    }
}
