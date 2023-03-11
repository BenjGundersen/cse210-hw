using System.IO;

class Program
{

    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        string choice = "";
        while (choice != "6")
        {
            DisplayMenu();
            choice = Console.ReadLine();
            switch(int.Parse(choice))
            {
                case 1: //creating goal
                    DisplayGoalMenu(goalList);
                    break;
                case 2: //list goals
                Console.Clear();
                foreach (Goal g in goalList)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(g.GetDisplayString());
                        Console.WriteLine("");
                    }
                    break;
                case 3: //save goals
                    Console.WriteLine("What do you want the filename to be: ");
                    string fileName = Console.ReadLine()+".txt";
                

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal g in goalList)
                        {
                            outputFile.WriteLine(g.GetDisplayString());
                        }
                    }
                    break;
                case 4: //load goals
                    Console.WriteLine("What is the nbame of the file you want to open: ");
                    string openFile = Console.ReadLine()+".txt";
                    string [] lines = System.IO.File.ReadAllLines(openFile);
                    foreach (string line in lines)
                    {
                        goalList.Add(line);
                    }
                    break;
                case 5: //record event
                    break;
                case 6: // quit
                    Console.WriteLine("Thanks for using the program.");
                    break;
                default: //for invalid options
                    break;
                    
            }
        }
        
        
        static void DisplayMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
        }

        static void DisplayGoalMenu(List<Goal> goalList)
        {

            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1. Simple goal");
            Console.WriteLine("  2. Eternal goal");
            Console.WriteLine("  3. Checklist goal");
            Console.Write("What kind of goal do you want to make: ");
            string goalChoice = Console.ReadLine();
            
            switch(int.Parse(goalChoice))
            {
                case 1:
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("How many points should be associated with this goal: ");
                    string goalPoints = Console.ReadLine();
                    int intgGoalPoints = int.Parse(goalPoints);
                    SimpleGoal theSimple = new SimpleGoal(goalName, goalDescription, intgGoalPoints, false);
                    goalList.Add(theSimple);
                    break;
                case 2:
                     Console.WriteLine("What is the name of your goal? ");
                    string eternalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string eternalDescription = Console.ReadLine();
                    Console.WriteLine("How many points should be associated with this goal: ");
                    string eternalPoints = Console.ReadLine();
                    int eGoalPoints = int.Parse(eternalPoints);
                    EternalGoal eGoal = new EternalGoal(eternalName, eternalDescription, eGoalPoints, false);
                    goalList.Add(eGoal);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}