using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage: ");
        string stringGradePercentage = Console.ReadLine();
        float gradePercentage = float.Parse(stringGradePercentage);
        string letter;
        if (gradePercentage >= 90)
        {
            //Console.WriteLine("You have A!");
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            //Console.WriteLine("You have B!");
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            //Console.WriteLine("You have C!");
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            //Console.WriteLine("You have D!");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("KYS!!!");
            letter = "F";
        }
        Console.WriteLine($"You have a {letter}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You pass the class!");
        }
        else
        {
            Console.WriteLine("You do not pass!");
        }
    }
}