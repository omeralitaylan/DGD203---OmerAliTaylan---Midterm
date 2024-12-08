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
    public static class ErrorHandler
    {
        public static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleUI.PrintSlow($"\nAn error occurred: {ex.Message}");
            Console.ResetColor();
        }

        public static bool ContinueAfterError()
        {
            ConsoleUI.PrintSlow("\nWould you like to continue? (Y/N): ");
            string input = Console.ReadLine()?.Trim().ToUpper() ?? "N";
            return input == "Y";
        }
    }
}
