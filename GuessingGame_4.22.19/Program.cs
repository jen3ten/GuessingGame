using System;

namespace GuessingGame_4._22._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!\n");
            bool guessAgain; 
            guessAgain = true;
            //bool guessAgain = true;
            
            int numberGuesses = 0;
            int randomNumber = new Random().Next(1, 101);

            Console.WriteLine("\nINSTRUCTIONS");
            Console.WriteLine("You have 3 tries to guess a number between 1-100.");
            Console.WriteLine("I will tell you if you are too high or too low or just right!");
            Console.WriteLine("Enter 0 to return to the instructions.");
            Console.WriteLine("Enter -1 to exit the game.");
            Console.WriteLine("");

            do
            {
                Console.Write("Please guess a number between 1-100: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("\nYou win!");
                    guessAgain = false;
                }
                else if (guess == 0)
                {
                    Console.WriteLine("\nINSTRUCTIONS");
                    Console.WriteLine("You have 3 tries to guess a number between 1-100.");
                    Console.WriteLine("I will tell you if you are too high or too low or just right!");
                    Console.WriteLine("Enter 0 to return to the instructions.");
                    Console.WriteLine("Enter -1 to exit the game.");
                }
                else if (guess == -1)
                {
                    guessAgain = false;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                    numberGuesses++;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                    numberGuesses++;
                }
            } while (guessAgain && (numberGuesses < 3));

            //This is string concatenation
            Console.WriteLine("\nThe number was " + randomNumber + ".\nThanks for playing!");

            //This is string interpolation
            Console.WriteLine($"\nThe number was {randomNumber}. \nThanks for playing!");

            //This is composite formatting
            Console.WriteLine("\nThe number was {0}. You guessed {1} times.\nThanks for playing!", randomNumber, numberGuesses);
        }
    }
}
