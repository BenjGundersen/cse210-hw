using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment theAssignment = new Assignment("Ben", "math");
        Console.WriteLine(theAssignment.getSummary());
        MathAssignment theMathAssignment = new MathAssignment("Ben", "math","Section 7","69");
        Console.WriteLine(theMathAssignment.getHomeworkList());
        WritingAssignment theWritingAssignment = new WritingAssignment("Ben", "math", "how to not hate youself while doing calc!");
        Console.WriteLine(theWritingAssignment.getWritingInformation());
    }
}