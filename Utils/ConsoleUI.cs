/*
Note: The project was completed in about 8 hours using AI
The game codes were created with "Claude 3.5 Sonnet"
The codes were edited in "WindSurf"
The game's story was created with "ChatGpt".
The story was integrated into the game with "Claude 3.5 Sonnet"
The game was tested with "Visual Studio 2022"
*/

using System;
using System.Threading;

namespace AHeroFarAway.Utils
{
    public static class ConsoleUI
    {
        private const int TypeSpeed = 15; // Reduced from 30 to 15 for faster text flow

        public static void PrintSlow(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(TypeSpeed);
            }
            Console.WriteLine();
        }

        public static void PrintPrompt(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(TypeSpeed);
            }
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }

        public static void ShowSuccessEnding(string playerName, string analysis)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PrintSlow("\n=== Mission Successful! ===");
            PrintSlow($"\nCaptain {playerName}, you have achieved something extraordinary!");
            PrintSlow("Your discoveries will forever change humanity's understanding of the universe.");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSlow(analysis);
            Console.ResetColor();
        }

        public static void ShowFailureEnding(string playerName, string analysis)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintSlow("\n=== Mission Failed ===");
            PrintSlow($"\nCaptain {playerName}, despite your best efforts, the mission ended in failure.");
            PrintSlow("The secrets of this mysterious planet will remain unknown for now.");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSlow(analysis);
            Console.ResetColor();
        }

        public static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                      A HERO FAR AWAY

o               .        ___---___                    .                   
       .              .--\        --.     .     .         .
                    ./.;_.\     __/~ \.     
                   /;  / `-'  __\    . \                            
 .        .       / ,--'     / .   .;   \        |
                 | .|       /       __   |      -O-       .
                |__/    __ |  . ;   \ | . |      |
                |      /  \\_    . ;| \___|    
   .    o       |      \  .~\\___,--'     |           .
                 |     | . ; ~~~~\_    __|
    |             \    \   .  .  ; \  /_/   .
   -O-        .    \   /         . |  ~/                  .
    |    .          ~\ \   .      /  /~          o
  .                   ~--___ ; ___--~       
                 .          ---         .              
");
            Console.ResetColor();
        }

        public static void ShowSecondAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                                YOUR MISSION BEGINS

                     `. ___
                    __,' __`.                _..----....____
        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'
  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'
,'________________                          \`-._`-','
 `._              ```````````------...___   '-.._'-:
    ```--.._      ,.                     ````--...__\-.
            `.--. `-`                       ____    |  |`
              `. `.                       ,'`````.  ;  ;`
                `._`.        __________   `.      \'__/`
                   `-:._____/______/___/____`.     \  `
                               |       `._    `.    \
                               `._________`-.   `.   `.___
                                                  `------'`
");
            Console.ResetColor();
        }
    }
}
