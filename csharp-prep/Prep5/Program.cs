using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber);

        
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }
        static int SquareNumber(int favoriteNumber)
        {
            int squaredNumber = favoriteNumber * favoriteNumber;

            return squaredNumber;
        }
        static void DisplayResults(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}