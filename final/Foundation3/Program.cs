using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("How to get good", "A lecture on how to simply get good", new Address("291 W 7th N", "Rexburger", "Idaho"), "7:00pm", "February 29th", "John Cena", 420);
        lecture.GetDetails();
        Console.WriteLine();
        lecture.Details();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();

        Reception reception = new Reception("Wedding thing", "A wedding reception!", new Address("291 W 7th N", "Rexburger", "Idaho"), "7:00pm", "February 29th", "veryrealemail@email.com");
        reception.GetDetails();
        Console.WriteLine();
        reception.Details();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();

        Outdoor outdoor = new Outdoor("Wedding thing", "A wedding reception!", new Address("291 W 7th N", "Rexburger", "Idaho"), "7:00pm", "February 29th", "Very cloudy and extremely rainy.");
        outdoor.GetDetails();
        Console.WriteLine();
        outdoor.Details();
        Console.WriteLine();
        outdoor.ShortDescription();
        Console.WriteLine();
    }
}