using System;
class Program
{
    static void Main()
    {
        // Step 1 Intro
        Console.WriteLine("Guess the secret number!");
        Console.WriteLine("------------------------");
        Console.WriteLine("");
        // Phase 7 Step 1 Difficulty level prompt
        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy (8 attempts)");
        Console.WriteLine("2. Medium (6 attempts)");
        Console.WriteLine("3. Hard (4 attempts)");
        Console.WriteLine("4. Cheater (Unlimited attempts)");
        // creates a placeholder to house the users choice - asks the user to chose the number for their preferred choice (will repeaditly ask until good answer is given)
        //readline listens for the readers
        int difficultyChoice;
        while (true)
        {
            Console.Write("Enter the number corresponding to your choice: ");
            if (int.TryParse(Console.ReadLine(), out difficultyChoice) && difficultyChoice >= 1 &&  difficultyChoice <= 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
        }
            // Step 1.2 Set maxAttempts based on difficulty
        int maxAttempts;
        switch (difficultyChoice)
        {
            case 1:
                maxAttempts = 8; // Easy
                break;
            case 2:
                maxAttempts = 6; // Medium
                break;
            case 3:
                maxAttempts = 4; // Hard
                break;
            case 4:
                maxAttempts = int.MaxValue; //Cheater
                break;

            default:
                   Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                return; // Exit the program or perform other appropriate actions
               
        }
        // Phase 2 Step 1
        int secretNumber = new Random().Next(0, 101);
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