using System;
using System.ComponentModel.DataAnnotations;

//Step 1 Intro 
Console.WriteLine("Guess the secret number!");
Console.WriteLine("------------------------");
Console.WriteLine("");


// step 2 User input
Console.WriteLine("Enter your guess: ");

// step 3 save users selection as a variable
string userAnswer = Console.ReadLine();
int parsedUserGuessString = int.Parse(userAnswer);


//step 4 Display users selection
// Console.WriteLine($@"
// You guessed " + parsedUserGuessString+"!");

//Phase 2 Step 1
int secretNumber = 42;

// Compare user guess with secret number
void compareSecret(int parsedUserGuessString)
{



    if (parsedUserGuessString == secretNumber)
    {
               Console.Write("Success!");
    }
    else {
        Console.Write("Bummer :(");
    }

}

compareSecret(parsedUserGuessString);

