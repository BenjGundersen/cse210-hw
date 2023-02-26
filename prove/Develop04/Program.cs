using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the mindfullnes program");
        string choice = "";
        int seconds = 0;
        while (choice != "0")
        {
            DisplayMenu();
            Console.WriteLine();
            choice = Console.ReadLine();

            switch(int.Parse(choice))
            {
                case 1: //breathing activity
                    Console.Clear();
                    BreathingActivity theBreathing = new BreathingActivity("Breathing", 0);
                    Console.WriteLine("Welcome to the breathing activity.");
                    seconds = theBreathing.SetDuration();
                    theBreathing.GetReady();
                    theBreathing.breathing(seconds);
                    break;

                case 2: //reflection activity
                    Console.Clear();
                    ReflectionActivity theReflection = new ReflectionActivity("reflect", 0);
                    Console.WriteLine("Welcome to the reflection activity.");
                    seconds = theReflection.SetDuration();
                    theReflection.GetReady();
                    theReflection.ShowPrompt(seconds);
                    break;

                case 3: //listing activity
                    ListingActivity theListing = new ListingActivity("listing", 0);
                    Console.WriteLine("Welcome to the listing activity.");
                    seconds = theListing.SetDuration();
                    theListing.GetReady();
                    theListing.ReturnPrompt(seconds);
                    break;

                case 0: //quit
                    Console.WriteLine("Thanks for using this program.");
                    break;

                default: //for invalid options
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option!");
                    break;

            }
        }
    }

    static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("0. Quit");
    }

}