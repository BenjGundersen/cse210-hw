using System;
// in order to a little above expectations, I added some pretty basic color cues in the console.
// Red for when something goes wrong (like typing 6 or higher when choosing an option)
// Blue when you are dealing with the prompts or when it is displaying the journal.
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        Console.WriteLine("It's journalin time.");
        
        string choice = "";

        while (choice != "0")
        {
            DisplayMenu();
            Console.WriteLine();
            choice = Console.ReadLine();

            switch(int.Parse(choice))
            {
                case 1:
                    string prompt = generator.GetRandomPrompt();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(prompt);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(">");
                    string userResponse = Console.ReadLine();
                    string dateTime = System.DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                    Entry theEntry = new Entry();
                    theEntry._date = dateTime;
                    theEntry._prompt = prompt;
                    theEntry._text = userResponse;

                    theJournal.AddEntry(theEntry);
                    break;
                case 2:
                    Console.Write("What is the name of the file: ");
                    string saveFile = Console.ReadLine();
                    theJournal.Save(saveFile);
                    break;
                case 3:
                    Console.Write("What is the name of the file you want to load: ");
                    string loadFile = Console.ReadLine();
                    theJournal.Load(loadFile);
                    break;
                case 4:
                    theJournal.Display();
                    break;
                case 0:
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option!");
                    break;

            }
        }
    }

    static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Save journal.");
        Console.WriteLine("3. Load Journal. (Will overwrite current journal)");
        Console.WriteLine("4. Display Journal entry.");
        Console.WriteLine("0. Quit");
    }
}