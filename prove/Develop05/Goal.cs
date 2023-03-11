class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completionStatus;

    public Goal(string name, string description, int points, bool completionStatus)
    {
        _name = name;
        _description = description;
        _points = points;
        _completionStatus = completionStatus;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointValue()
    {
        return _points;
    }
    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    } 
    public virtual string GetDisplayString()
    {
        //should return information about the goal
        return "";
    }
}