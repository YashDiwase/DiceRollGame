// See https://aka.ms/new-console-template for more information



using System.Diagnostics;

Display.print();
var randomNumber = RandomNumberGenerator.getRandomNumber();
var user = new User();
static void printforWrongInput()
{
    Console.WriteLine("Wrong number.");
}
while (user.Attempt < User.MaxAttempt)
{
    Console.WriteLine("Enter a number:");
    var input = Console.ReadLine();
    int number;
    bool isParsingSuccessful = int.TryParse(input, out number);
    if (isParsingSuccessful)
    {
        user.Attempt++;
        if (randomNumber == number)
        {
            Console.WriteLine("You win!");
            user.Lose = false;
            break;
        }
        else
        {
            printforWrongInput();
        }
    }

}

if (user.Lose)
{
    Console.WriteLine("You lose!");
    Console.WriteLine($"Random number between [1,6] was: {randomNumber}");
}

Console.ReadKey();

