// See https://aka.ms/new-console-template for more information



public static class RandomNumberGenerator
{
    public static int getRandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 7); // Generates a number between 1 and 6 (inclusive)
        return randomNumber;
    }
}

