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
    public abstract class BaseStoryPath
    {
        protected readonly Player player;

        protected BaseStoryPath(Player player)
        {
            this.player = player;
        }

        public abstract void Execute();

        protected string GetPlayerChoice(string optionA, string optionB)
        {
            InputHandler.PrintOptionA(optionA);
            InputHandler.PrintOptionB(optionB);
            Console.Write("Your choice (A/B): ");
            string choice = InputHandler.GetValidInput("", new[] { "A", "B" });
            player.AddChoice(choice);
            return choice;
        }

        protected void ShowSuccess()
        {
            ConsoleUI.ShowSuccessEnding(player.GetName(), player.AnalyzeChoices());
        }

        protected void ShowFailure()
        {
            ConsoleUI.ShowFailureEnding(player.GetName(), player.AnalyzeChoices());
        }

        protected string ProcessChoices(string[] questions, string[][] choices)
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
