/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using AHeroFarAway.Utils;
using AHeroFarAway.StoryPaths;

namespace AHeroFarAway
{
    public class StoryPath : BaseStoryPath
    {
        public StoryPath(Player player) : base(player)
        {
        }

        public override void Execute()
        {
            StartGame();
        }

        private void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ConsoleUI.PrintSlow($"\nIn 2098, Turkey joins the space race with its revolutionary starship \"Erlik\".");
            ConsoleUI.PrintSlow($"Captain {player.GetName()}, you lead a six-person crew to explore a mysterious planet in a distant galaxy.");
            ConsoleUI.PrintSlow("Your mission: investigate the planet and bring vital information back to Earth.");
            ConsoleUI.PrintSlow("\nUpon landing, you find yourself in an alien world with unfamiliar skies.");
            ConsoleUI.PrintSlow("Strange events begin to unfold, threatening your team's survival and Earth connection.");
            ConsoleUI.PrintSlow("\nAs you exit the Erlik, you must choose your next move:");
            
            InputHandler.PrintOptionA("Investigate the strange symbols near the ship's landing site");
            InputHandler.PrintOptionB("Head into the dense forest that stretches before you");
            
            string choice = InputHandler.GetValidInput("Your choice (A/B): ", new[] { "A", "B" });
            player.AddChoice(choice);

            BaseStoryPath path;
            if (choice == "A")
            {
                player.SetPath("Explorer");
                path = new SymbolsPath(player);
            }
            else
            {
                player.SetPath("Survival");
                path = new ForestPath(player);
            }

            path.Execute();
        }
    }
}
