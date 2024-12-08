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
    public class ForestPath : BaseStoryPath
    {
        public ForestPath(Player player) : base(player)
        {
        }

        public override void Execute()
        {
            string[] questions = {
                "\nAs you venture deeper into the forest, you notice strange bioluminescent plants.",
                "\nYou discover tracks of an unknown creature.",
                "\nYou find what appears to be an abandoned settlement.",
                "\nYou hear unusual sounds echoing through the trees.",
                "\nYou discover a clearing with unusual rock formations.",
                "\nYou find evidence of recent activity.",
                "\nYou encounter a strange energy field.",
                "\nYou discover a hidden entrance to an underground chamber."
            };

            string[][] choices = {
                new[] { "Collect samples for analysis", "Document from a safe distance" },
                new[] { "Follow the tracks deeper into the forest", "Mark the location and continue searching" },
                new[] { "Enter and explore the settlement", "Survey from the perimeter" },
                new[] { "Move toward the source of the sounds", "Find a defensible position" },
                new[] { "Examine the formations up close", "Take readings from a distance" },
                new[] { "Search for the source", "Set up surveillance equipment" },
                new[] { "Attempt to pass through the field", "Study it from outside" },
                new[] { "Enter the chamber", "Secure the entrance and call for backup" }
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
