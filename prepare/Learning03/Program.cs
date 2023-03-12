using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();
        Fraction two = new Fraction(5);
        Fraction three = new Fraction(6,7);
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
    }
}