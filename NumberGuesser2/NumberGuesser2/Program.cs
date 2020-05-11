using System;
//Namespace
namespace NumberGuesser2
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run GetAppInfo function to get info
            GetAppInfo();

            //Ask for user name and print it with a message to console
            GreetUser();

            while (true) {

                //Create a new random object
                Random random = new Random();

                //initialize correct numner (random)
                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                //Ask player to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not equal correct number keep asking
                while (guess != correctNumber) {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess)) {

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess against correct Number
                    if (guess != correctNumber) {

                        //Calling PrintColorMessage to change color and print a message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please guess again.");
                        //Change text colour
                        /*Console.ForegroundColor = ConsoleColor.Red;*/

                        //Tell user wrong number
                        /*Console.WriteLine("Wrong number. Please guess again.");*/

                        //Reset text colour 
                        Console.ResetColor();
                    }
                }

                //Exit while. Output successful guess message

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //Reset text colour 
                Console.ResetColor();

                //Ask user to play again
                Console.WriteLine("Do you want to play again? Y/N?");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }

        static void GetAppInfo() {

            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "Version 1.0.0";
            string appAuthor = "LKS";

            //Calling PrintColorMessage to change color and print a message
            PrintColorMessage(ConsoleColor.Green, $"{appName}:{appVersion}, by {appAuthor}");
         
            //Change text colour
            /*Console.ForegroundColor = ConsoleColor.Green;*/

            //Write out app info
            /*Console.WriteLine($"{appName}:{appVersion}, by {appAuthor}");*/

            //Reset text colour 
            Console.ResetColor();
        }

        static void GreetUser() {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //Store user name
            string inputName = Console.ReadLine();

            //Print to console message with user name
            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            //Change text colour
            Console.ForegroundColor = color;

            //Tell user to enter a number
            Console.WriteLine(message);

            //Reset text colour 
            Console.ResetColor();
        }
    }
}
