class Reception : Event
{
    private string _email;

    public Reception (string title, string description, Address address, string time, string date, string email) : base(title, description, address, time, date)
    {
        _email = email;
    }

    public void Details()
    {
        GetDetails();
        Console.WriteLine($"RSVP email: {_email}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: Reception");
        ShortDetails();
    }
}