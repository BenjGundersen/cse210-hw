class Running : Activity
{
    private double _distance;
    public Running (string date, double minutes, double distance) : base (date, minutes)
    {
        _distance = distance;
    }
    public override string GetActivity()
    {
        return "Running";
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_minutes / _distance);
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}