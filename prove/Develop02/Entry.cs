class Entry
{
    public string _prompt;
    public string _text;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}: {_text}"); 
    }
}