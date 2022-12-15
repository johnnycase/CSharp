using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            string inputGuess = "";
            int numOfguess = 0;
            int numGuess;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            while (inputGuess != theNumber | -1){
                Console.WriteLine("What's your guess?");

                inputGuess = Console.ReadLine();

                try {
                    numGuess = int.Parse(inputGuess);
                }
                catch {
                    Console.Write("Hmm, that doesn't look like a number. Try again.")
                }

                switch (numGuess)  {
                    case > theNumber:
                        Console.WriteLine("Nope, lower than that.");
                        numOfguess++;
                    case < theNumber:
                        Console.WriteLine("Nope, higher than that.");
                        numOfguess++;
                    case == theNumber:
                        Console.WriteLine($"You got it in {numOfGuess} guesses!!");
                        break;
                    case == -1:
                        Console.WriteLine("Thank you for playing, goodbye!");
                        break;
                }            
            }
            
        }
    }
}
