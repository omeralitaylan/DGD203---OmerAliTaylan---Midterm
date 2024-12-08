/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;

namespace AHeroFarAway.Utils
{
    public static class InputHandler
    {
        public static string GetValidInput(string prompt, string[] validInputs)
        {
            string input;
            bool firstAttempt = true;

            while (true)
            {
                if (!string.IsNullOrEmpty(prompt))
                {
                    Console.Write(prompt);
                }

                if (!firstAttempt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid input! Please enter 'A' or 'B': ");
                    Console.ResetColor();
                }
                
                input = Console.ReadLine()?.Trim().ToUpper() ?? "";
                firstAttempt = false;

                if (input == "A" || input == "B")
                {
                    return input;
                }
            }
        }

        public static void PrintOptionA(string option)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"A) {option}");
            Console.ResetColor();
        }

        public static void PrintOptionB(string option)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"B) {option}");
            Console.ResetColor();
        }
    }
}
