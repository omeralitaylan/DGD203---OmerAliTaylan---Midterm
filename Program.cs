/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;
using System.Text;
using AHeroFarAway.Utils;

namespace AHeroFarAway
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Title = "A Hero Far Away";
                
                if (OperatingSystem.IsWindows())
                {
                    Console.WindowWidth = 120;
                    Console.WindowHeight = 30;
                    Console.BufferWidth = 120;
                    Console.BufferHeight = 3000;
                }
                
                ConsoleUI.ShowAsciiArt();
                ConsoleUI.PrintSlow("\n=== A Hero Far Away ===\n");
                ConsoleUI.PrintSlow("Welcome to your space adventure!\n");
                
                var game = new Game();
                game.Start();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nCritical error occurred: {ex.Message}");
                Console.WriteLine("Please restart the game.");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey(true);
            }
        }

        private static void SetupConsole()
        {
            Console.CursorVisible = true;
            
            try
            {
                if (OperatingSystem.IsWindows())
                {
                    Console.WindowWidth = Math.Min(Console.LargestWindowWidth, 120);
                    Console.WindowHeight = Math.Min(Console.LargestWindowHeight, 30);
                    Console.BufferWidth = Console.WindowWidth;
                    Console.BufferHeight = 3000;
                }
            }
            catch
            {
                // Ignore console resize errors - some environments don't support this
            }

            Console.Clear();
        }
    }
}