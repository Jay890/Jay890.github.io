using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odssOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOne;
            int playerTwo;
            int randomNumber;

            Console.WriteLine("Odds on game. Choose a number between 1 and 3, if its the same number you loose.");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            //playerOne = Console.ReadLine();
            playerOne = intTemp;
            //playerOne = intTemp;
         
            //random number generator using seed
            //Console.WriteLine(playerOne);
            //Console.WriteLine(intTemp);
            Random rnd = new Random();

            //set the bounds for randomNumber while using rnd generator, range from 1-3
            randomNumber = rnd.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    playerTwo = 1;
                    Console.WriteLine("Player two has chosen 1");
                    if (playerOne > 5 || playerOne < 1) 
                        //this condition doesn't take affect, because the random number was not 1, as was range from 1-5, so the playerTwo = 1 condition was not filled sometimes
                        //FIXED by adding in the additional cases
                    {
                        Console.WriteLine("Choose a number between 1 and 5");
                    }
                    else if (playerOne == 1)
                    {
                        Console.WriteLine("You loose");
                    }
                    else if (playerOne != 1)
                    {
                        Console.WriteLine("You win");
                    }
                 
                    break;
                case 2:
                    playerTwo = 2;
                    Console.WriteLine("Player two has chosen 2");
                    if (playerOne > 5 || playerOne < 1)
                    {
                        Console.WriteLine("Choose a number between 1 and 5");
                    }
                    else if (playerOne == 2)
                    {
                        Console.WriteLine("You loose");
                    }
                    else if (playerOne != 2)
                    {
                        Console.WriteLine("You win");
                    }
                    break;
                case 3:
                    playerTwo = 3;
                    Console.WriteLine("Player two has chosen 3");
                    if (playerOne > 5 || playerOne < 1)
                    {
                        Console.WriteLine("Choose a number between 1 and 5");
                    }
                    else if (playerOne == 3)
                    {
                        Console.WriteLine("You loose");
                    }
                    else if (playerOne != 3)
                    {
                        Console.WriteLine("You win");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
