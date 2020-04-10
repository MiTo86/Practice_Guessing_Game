using System;

namespace Practice_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "hello";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("Welcome to the Guessing Game. You have 3 guesses.");
            Console.WriteLine("The hint is: A word used in greeting.");

            while (guess != secretWord  && !outOfGuesses)
            {


                if (guessCount < guessLimit)
                {
                    {
                        Console.Write("Enter a guess: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose.");
            }
            else
            {
                Console.Write("You Win!");
            }
                        
            Console.ReadLine();
        }
    }
}
