/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;
using AHeroFarAway.Utils;

namespace AHeroFarAway
{
    public class Game
    {
        private readonly Player player;
        private readonly StoryPath storyPath;

        public Game()
        {
            player = new Player();
            storyPath = new StoryPath(player);
        }

        public void Start()
        {
            try
            {
                InitializeGame();
                RunGame();
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
            finally
            {
                ConsoleUI.PressAnyKeyToContinue();
            }
        }

        private void InitializeGame()
        {
            string playerName = PlayerValidator.GetValidPlayerName();
            player.SetName(playerName);
            
            ConsoleUI.ClearScreen();
            ConsoleUI.ShowSecondAsciiArt();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleUI.PrintSlow($"\nWelcome, {player.GetName()}! Your journey into the unknown begins...\n");
            Console.ResetColor();
            ShowIntroduction();
        }

        private void RunGame()
        {
            storyPath.Execute();
        }

        private void ShowIntroduction()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleUI.PrintSlow("\nYou are a space explorer on a critical mission to investigate mysterious signals...");
            ConsoleUI.PrintSlow("Your decisions will shape the outcome of this mission. Choose wisely.\n");
            Console.ResetColor();
            ConsoleUI.PressAnyKeyToContinue();
            ConsoleUI.ClearScreen();
        }
    }
}