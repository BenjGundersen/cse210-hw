class Bicycle : Activity
{
    private double _speed;
    public Bicycle (string date, double minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }
    public override string GetActivity()
    {
        return "Biking";
    }
    public override double GetDistance()
    {
        return (_minutes / GetPace());
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}