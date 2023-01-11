using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string stringNumberAdded;
        int numberAdded;
        //int sum;
        float average;
        int largestNumber;
        do
        {
            Console.Write("Enter Number: ");
            stringNumberAdded = Console.ReadLine();
            numberAdded = int.Parse(stringNumberAdded);
            numbers.Add(numberAdded);
        } while (numberAdded != 0);
        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());
        
    }
}