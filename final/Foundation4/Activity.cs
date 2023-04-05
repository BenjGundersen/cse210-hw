abstract class Activity 
{
    private string _date;
    protected double _minutes;

    public Activity (string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract string GetActivity();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetActivity()} ({_minutes} min)- Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)}mph, Pace {Math.Round(GetPace(), 2)} min per mile.");
    }
}