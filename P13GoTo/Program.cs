


using System.Globalization;

// dot (not comma) for numbers ex- 0.5 not 0,5
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Random random = new Random();

int myNumber = random.Next(1, 101);

// Rules
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

bool guessedCorrectly = false;

while (!guessedCorrectly)
{
    // Asks user for their guess
    Console.Write("Your guess: ");
    string userInput = Console.ReadLine();
    int guess = int.Parse(userInput);

    // Check if the guess is greater, less, or equal to the number
    if (guess > myNumber)
    {
        Console.WriteLine("Nope! My number is Smaller!");
    }
    else if (guess < myNumber)
    {
        Console.WriteLine("Nope! My number is Greater!");
    }
    else
    {
        Console.WriteLine("That's the number! Well played!");
        guessedCorrectly = true;
    }
}
