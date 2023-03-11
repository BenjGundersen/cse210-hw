class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool completionStatus) : base (name, description, points, completionStatus)
    {
    }


    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        bool completionStatus = true;
        return completionStatus;
    }
    public override string GetDisplayString()
    {
        string name = GetName();
        string description = GetDescription();
        return $"[ ] {name} ({description})";
    }
}