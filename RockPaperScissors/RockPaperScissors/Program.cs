using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string appName = "RockPaperScissors";
            string versionGame = "Version 1.0";
            string creatorName = "Captain";

            PrintColorMessage(ConsoleColor.Yellow, $"{ appName}: { versionGame}, by { creatorName}");

            Console.WriteLine("What is your name?");

            string namePlayer = Console.ReadLine();

            PrintColorMessage(ConsoleColor.Green, $"Welcome {namePlayer}. I am the game master.");

            Program.PlayGame();
        }

        static void PlayGame()
        {

            Console.WriteLine("Please choose rock, paper or scissor.");

            string yourChoice = Console.ReadLine();

            if (yourChoice == "rock")
            {
                PrintColorMessage(ConsoleColor.Cyan, "You have played rock, your oppenent has played rock. Draw.");
            }
            else if (yourChoice == "paper")
            {
                PrintColorMessage(ConsoleColor.Green, "You have played paper, your oppenent has played rock. You win.");
            }
            else if (yourChoice == "scissor")
            {
                PrintColorMessage(ConsoleColor.Red, "You have played scissor, your oppenent has played rock. You Lose.");
            }
            Console.WriteLine("Do you want to play again? Y/N");
            string repeatGame = Console.ReadLine().ToUpper();
            if (repeatGame == "Y")
            {
                PlayGame();
            }
            else
            {
                return;
            }
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
