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
    public class ExplorationPath : BaseStoryPath
    {
        public ExplorationPath(Player player) : base(player)
        {
        }

        public override void Execute()
        {
            ConsoleUI.PrintSlow("\nYou continue your exploration, focusing on finding signs of life.");
            
            string choice = GetPlayerChoice(
                "Follow a trail of unusual footprints",
                "Search for settlements or structures"
            );

            HandleExplorationChoice(choice);
        }

        private void HandleExplorationChoice(string initialChoice)
        {
            string[] questions = {
                "\nYou discover signs of advanced technology.",
                "\nYou find evidence of recent activity.",
                "\nYou encounter unusual atmospheric readings.",
                "\nYou detect faint energy signatures.",
                "\nYou discover a network of caves.",
                "\nYou find mysterious artifacts.",
                "\nYou encounter an energy barrier.",
                "\nYou reach what appears to be a control center."
            };

            string[][] choices = {
                new[] { "Investigate the technology", "Document and move on" },
                new[] { "Track the source", "Set up monitoring equipment" },
                new[] { "Enter the affected area", "Take readings from outside" },
                new[] { "Follow the energy trail", "Record data from a distance" },
                new[] { "Explore the cave system", "Map from the entrance" },
                new[] { "Attempt to activate the artifacts", "Collect samples only" },
                new[] { "Try to penetrate the barrier", "Study its properties" },
                new[] { "Access the control systems", "Secure the perimeter" }
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
