class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool completionStatus) : base (name, description, points, completionStatus)
    {

    }
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDisplayString()
    {
        string name = GetName();
        string description = GetDescription();
        return $"[ ] {name} ({description})";
    }
}