class Event
{
    private string _title;
    private string _description;
    private Address _address;
    private string _time;
    private string _date;

    public Event (string title, string description, Address address, string time, string date)
    {
        _title = title;
        _description = description;
        _address = address;
        _time = time;
        _date = date;
    }

    public void GetDetails()
    {
        Console.WriteLine($"Event Title: {_title}\nEvent Date & Time: {_date} {_time}\nEvent Address: {_address.GetAddress()} \nEvent Description {_description}");
    }

    public void ShortDetails()
    {
        Console.WriteLine($"Event Title: {_title}\nDate: {_date}");
    }
}