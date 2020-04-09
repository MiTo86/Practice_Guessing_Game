using System;

namespace Practice_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "hello";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter a guess.");
                guess = Console.ReadLine();
            }
            Console.Write("You Win!");

            Console.ReadLine();
        }
    }
}
