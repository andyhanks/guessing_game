using System;

class Program
{
    static void Main()
    {
        // Step 1 Intro 
        Console.WriteLine("Guess the secret number!");
        Console.WriteLine("------------------------");
        Console.WriteLine("");

        // Phase 2 Step 1
        int secretNumber = new Random().Next(0, 101);
        int maxAttempts = 6;
        int attempts = 0;

 while (attempts < maxAttempts)
        {
            // Step 2 User input
            Console.WriteLine("Enter your guess: ");

            // Step 3 Save user's selection as a variable
            string userAnswer = Console.ReadLine();
            int parsedUserGuessString;

            // Validate user input
            if (!int.TryParse(userAnswer, out parsedUserGuessString))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            attempts++;

            // Compare user guess with secret number
            if (parsedUserGuessString == secretNumber)
            {
                Console.WriteLine("Success!");
                break; // Exit loop if the guess is correct
            }
            else if (parsedUserGuessString < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }

            if (attempts < maxAttempts)
            {
                Console.WriteLine($"You have {maxAttempts - attempts} attempt(s) left.");
            }
        }

        if (attempts == maxAttempts)
        {
            Console.WriteLine($"You've used all your attempts. The secret number was {secretNumber}.");
        }
    }
}