class Swimming : Activity
{
    private int _laps;
    public Swimming (string date, double minutes, int laps) : base (date, minutes)
    {
        _laps = laps;
    }
    public override string GetActivity()
    {
        return "Swimming";
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }    
}