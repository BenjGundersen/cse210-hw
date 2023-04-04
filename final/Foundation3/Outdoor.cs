class Outdoor : Event
{
    private string _weather;

    public Outdoor (string title, string description, Address address, string time, string date, string weather) : base(title, description, address, time, date)
    {
        _weather = weather;
    }

    public void Details ()
    {
        GetDetails();
        Console.WriteLine($"Weather: {_weather}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: Outdoors");
        ShortDetails();
    }
}