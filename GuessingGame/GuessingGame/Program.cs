using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int playerGuess;
            string playerName = "";
            string playerInput;
            
            int guessCounter = 0;
            Random r = new Random();
            theAnswer = r.Next(1, 21);
            Console.WriteLine("Enter your name:");
            
            playerName = Console.ReadLine();
            
            do
            {
                
                // get player input
                Console.Write($"Enter your guess (1-20), {playerName}: ");
                playerInput = Console.ReadLine();
                guessCounter += 1;
                Console.ResetColor();
                //attempt to convert the string to a number
                if (playerInput == "Q" || playerInput == "q")
                {
                    Environment.Exit(0);
                }
                    
                 else if (int.TryParse(playerInput, out playerGuess))
                {
                    if (playerGuess == theAnswer && guessCounter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{theAnswer} was the number. Wow!  First try!  You Win!");
                        break;
                    }
                    else if (playerGuess == theAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{theAnswer} was the number. You Win!  It took {guessCounter} tries!");
                        break;
                    }
                    else
                    {
                        if (playerGuess > theAnswer)
                        {
                            Console.WriteLine("Your guess was too High!");
                        }
                        else
                        {
                            Console.WriteLine("Your guess was too low!");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That wasn't a number!");
                }

            } while (true);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
        
    }
}
