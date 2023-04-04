class Lecture : Event 
{
    private string _speaker;
    private int _capacity;
    public Lecture (string title, string description, Address address, string time, string date, string speaker, int capacity) : base(title, description, address, time, date)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void Details()
    {
        GetDetails();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }

    public void ShortDescription() 
    {
        Console.WriteLine($"Event Type: Lecture");
        ShortDetails();
    }
}