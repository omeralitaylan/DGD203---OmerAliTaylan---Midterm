/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;
using System.Globalization;

namespace AHeroFarAway.Utils
{
    public static class PlayerValidator
    {
        public static string GetValidPlayerName()
        {
            string name;
            bool firstAttempt = true;

            while (true)
            {
                if (firstAttempt)
                {
                    Console.Write("\nEnter your name, Captain: ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid name! Please enter a valid name (2-20 characters): ");
                    Console.ResetColor();
                }

                name = Console.ReadLine()?.Trim() ?? "";
                firstAttempt = false;

                if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 20)
                {
                    continue;
                }

                if (IsValidName(name))
                {
                    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                }
            }
        }

        private static bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }
    }
}
