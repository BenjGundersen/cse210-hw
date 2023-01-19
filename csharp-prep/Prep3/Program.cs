using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);
        string stringMagicNumber = magicNumber.ToString();
        string stringNumberGuess;
        do
        {
            Console.WriteLine("What is your guess? ");
            stringNumberGuess = Console.ReadLine();
            int numberGuess = int.Parse(stringNumberGuess);

            if (numberGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (numberGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (stringNumberGuess != stringMagicNumber);
        
    }
}