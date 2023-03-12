using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");


        Reference theReference = new Reference("John", 3, 16);
        string text = "For God so loved the world...";
        Scripture theScripture = new Scripture(theReference, text);
        Console.WriteLine(theReference.GetReferenceText()+"-"+text);
        theScripture.HideWords(2);
    }
}