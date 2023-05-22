// See https://aka.ms/new-console-template for more information
// simple guessing game

Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String response = "";

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine("Guess a number between " + min + " and " + max + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
    
        if (guess > number)
        {
            Console.WriteLine("You guessed too high");
        }

        else if (guess < number)
        {
            Console.WriteLine("You guessed too low");
        }
        guesses++;
    }
    Console.WriteLine("You win! The number is " + number);
    Console.WriteLine("You did it in " + guesses + " guesses");

    Console.WriteLine("Would you like to play again? (y/n)");
    response = Console.ReadLine();
    response = response.ToLower();

    if (response != "y")
    {
        Console.WriteLine("Thanks for playing!");
        playAgain = false;
    }
}