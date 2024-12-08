/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using AHeroFarAway.Utils;

namespace AHeroFarAway.StoryPaths
{
    public class SymbolsPath : BaseStoryPath
    {
        public SymbolsPath(Player player) : base(player)
        {
        }

        public override void Execute()
        {
            ConsoleUI.PrintSlow("\nYou decide to investigate the symbols, drawn in a language unknown to you.");
            ConsoleUI.PrintSlow("They seem to glow faintly in the dim light of the planet's twin moons.");
            
            string choice = GetPlayerChoice(
                "Examine the symbols closely, trying to decode them",
                "Leave the symbols and continue looking for any sign of life"
            );

            if (choice == "A")
            {
                HandleSymbolDecoding();
            }
            else
            {
                new ExplorationPath(player).Execute();
            }
        }

        private void HandleSymbolDecoding()
        {
            ConsoleUI.PrintSlow("\nThe symbols begin to make sense, revealing a hidden underground base beneath the surface.");
            ConsoleUI.PrintSlow("It seems as if the planet was once home to a highly advanced civilization.");
            
            string choice = GetPlayerChoice(
                "Enter the underground base and explore",
                "Mark the location and return to the surface to gather more information"
            );

            if (choice == "A")
            {
                HandleUndergroundExploration();
            }
            else
            {
                new ExplorationPath(player).Execute();
            }
        }

        private void HandleUndergroundExploration()
        {
            string[] questions = {
                "\nYou enter the underground facility. Ancient technology surrounds you.",
                "\nYou discover a control panel with strange markings.",
                "\nAn alarm suddenly blares through the facility.",
                "\nYou find a room filled with data crystals.",
                "\nThe facility's power begins to fluctuate.",
                "\nYou discover what appears to be a map room.",
                "\nThe facility's security systems activate.",
                "\nYou reach what seems to be the central chamber."
            };

            string[][] choices = {
                new[] { "Investigate the technology further", "Document and leave quickly" },
                new[] { "Attempt to activate the control panel", "Search for a manual interface" },
                new[] { "Try to shut down the alarm system", "Prepare for immediate evacuation" },
                new[] { "Download the data to your devices", "Take physical samples only" },
                new[] { "Try to stabilize the power grid", "Begin evacuation procedures" },
                new[] { "Study the star charts in detail", "Take quick photographs and leave" },
                new[] { "Try to override the systems", "Find an alternative exit" },
                new[] { "Risk everything to save the alien data", "Prioritize team safety" }
            };

            string finalChoice = ProcessChoices(questions, choices);
            if (finalChoice == "A")
            {
                ShowSuccess();
            }
            else
            {
                ShowFailure();
            }
        }

        protected new string ProcessChoices(string[] questions, string[][] choices)
        {
            string choice = "";
            for (int i = 0; i < questions.Length; i++)
            {
                ConsoleUI.PrintSlow(questions[i]);
                choice = GetPlayerChoice(choices[i][0], choices[i][1]);
            }
            return choice;
        }
    }
}
