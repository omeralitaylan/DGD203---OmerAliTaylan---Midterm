/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AHeroFarAway
{
    public class Player
    {
        private string name = string.Empty;
        private string currentPath;
        private readonly List<string> choices;
        private int score;

        public Player()
        {
            choices = new List<string>();
            score = 0;
            currentPath = string.Empty;
        }

        public void SetName(string playerName)
        {
            name = playerName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPath(string path)
        {
            currentPath = path;
        }

        public string GetPath()
        {
            return currentPath;
        }

        public void AddChoice(string choice)
        {
            choices.Add(choice);
            if (choice == "A")
            {
                score += 10;
            }
        }

        public List<string> GetChoices()
        {
            return choices;
        }

        public int GetScore()
        {
            return score;
        }

        public void Reset()
        {
            choices.Clear();
            score = 0;
            currentPath = string.Empty;
        }

        public bool HasMadeRiskyChoices()
        {
            int riskyChoices = choices.Count(c => c == "A");
            return riskyChoices > choices.Count / 2;
        }

        public bool HasMadeConservativeChoices()
        {
            int conservativeChoices = choices.Count(c => c == "B");
            return conservativeChoices > choices.Count / 2;
        }

        public string AnalyzeChoices()
        {
            int totalChoices = choices.Count;
            if (totalChoices == 0) return "You made no significant choices during your mission.";

            int riskyChoices = choices.Count(c => c == "A");
            int cautiousChoices = choices.Count(c => c == "B");
            double riskyPercentage = (double)riskyChoices / totalChoices * 100;

            StringBuilder analysis = new StringBuilder();
            analysis.AppendLine("\n╔════════════════════════════════════════════════════════════╗");
            analysis.AppendLine("║                   MISSION ANALYSIS REPORT                   ║");
            analysis.AppendLine("╚════════════════════════════════════════════════════════════╝");
            
            // Commander Profile
            analysis.AppendLine("\n► Commander Profile:");
            analysis.AppendLine($"   Name: Captain {name}");
            analysis.AppendLine($"   Mission Path: {currentPath}");
            analysis.AppendLine($"   Mission Status: {(HasMadeRiskyChoices() ? "High-Risk Operation" : "Standard Protocol")}");

            // Leadership Style Analysis
            analysis.AppendLine("\n► Leadership Assessment:");
            if (riskyPercentage > 75)
            {
                analysis.AppendLine("   Style: Bold Pioneer");
                analysis.AppendLine("   You are a daring and decisive leader, consistently choosing to face challenges");
                analysis.AppendLine("   head-on. Your courage in the face of the unknown marks you as a true pioneer");
                analysis.AppendLine("   of space exploration. Your willingness to take calculated risks has pushed");
                analysis.AppendLine("   the boundaries of human knowledge.");
            }
            else if (riskyPercentage > 50)
            {
                analysis.AppendLine("   Style: Balanced Tactician");
                analysis.AppendLine("   You demonstrate remarkable balance in your leadership approach, carefully");
                analysis.AppendLine("   weighing risks against potential discoveries. Your adaptability and");
                analysis.AppendLine("   tactical decision-making have proven invaluable throughout the mission.");
            }
            else if (riskyPercentage > 25)
            {
                analysis.AppendLine("   Style: Methodical Strategist");
                analysis.AppendLine("   You favor a cautious and methodical approach, prioritizing mission integrity");
                analysis.AppendLine("   and crew safety. Your careful planning and strategic thinking have helped");
                analysis.AppendLine("   navigate through numerous uncertain situations.");
            }
            else
            {
                analysis.AppendLine("   Style: Conservative Guardian");
                analysis.AppendLine("   You are an extremely cautious leader, placing the highest priority on");
                analysis.AppendLine("   safety and security. Your conservative approach has established new");
                analysis.AppendLine("   standards for risk management in deep space exploration.");
            }

            // Mission Path Analysis
            analysis.AppendLine("\n► Mission Path Analysis:");
            if (currentPath == "Explorer")
            {
                analysis.AppendLine("   Path Focus: Scientific Discovery");
                analysis.AppendLine("   As an Explorer, you prioritized the advancement of human knowledge.");
                analysis.AppendLine("   Your dedication to uncovering the planet's mysteries has yielded");
                analysis.AppendLine("   invaluable data that will benefit future expeditions. Your thorough");
                analysis.AppendLine("   documentation of alien phenomena will be studied for years to come.");
            }
            else if (currentPath == "Survival")
            {
                analysis.AppendLine("   Path Focus: Security Operations");
                analysis.AppendLine("   Taking the Survival path, you excelled in maintaining operational");
                analysis.AppendLine("   security and crew safety. Your defensive protocols and contingency");
                analysis.AppendLine("   planning have set new standards for deep space mission security.");
            }

            // Decision Analytics
            analysis.AppendLine("\n► Decision Analytics:");
            analysis.AppendLine($"   Total Mission Decisions: {totalChoices}");
            analysis.AppendLine($"   Bold Initiatives: {riskyChoices} ({riskyPercentage:F1}%)");
            analysis.AppendLine($"   Cautious Approaches: {cautiousChoices} ({100 - riskyPercentage:F1}%)");
            analysis.AppendLine($"   Decision Pattern: {GetDecisionPattern(riskyPercentage)}");

            // Mission Impact Assessment
            analysis.AppendLine("\n► Long-Term Impact Analysis:");
            if (HasMadeRiskyChoices())
            {
                analysis.AppendLine("   Your pioneering decisions have redefined the boundaries of space");
                analysis.AppendLine("   exploration. While your methods carried elevated risk levels, they");
                analysis.AppendLine("   have opened new frontiers and possibilities for future missions.");
                analysis.AppendLine("   Your data will be crucial for planning future high-risk operations.");
            }
            else
            {
                analysis.AppendLine("   Your methodical approach has established robust safety protocols");
                analysis.AppendLine("   that will become standard procedure for future deep space missions.");
                analysis.AppendLine("   Your careful documentation and risk management strategies will");
                analysis.AppendLine("   serve as a foundation for safe space exploration.");
            }

            // Final Evaluation
            analysis.AppendLine("\n► Final Evaluation:");
            analysis.AppendLine($"   Captain {name}, your {currentPath.ToLower()} mission has contributed");
            analysis.AppendLine("   significantly to our understanding of deep space exploration.");
            analysis.AppendLine("   Your leadership style and decision-making approach have set");
            analysis.AppendLine("   valuable precedents for future space missions.");

            analysis.AppendLine("\n═══════════════════════ End of Report ═══════════════════════");

            return analysis.ToString();
        }

        private string GetDecisionPattern(double riskyPercentage)
        {
            if (riskyPercentage > 75) return "Consistently Bold";
            if (riskyPercentage > 50) return "Balanced with Bold Tendency";
            if (riskyPercentage > 25) return "Balanced with Cautious Tendency";
            return "Consistently Cautious";
        }
    }
}
