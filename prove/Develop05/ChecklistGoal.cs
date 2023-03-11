class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _amountCompleted;
    private int _desiredAmount;

    public ChecklistGoal(string name, string description, int points, bool completionStatus, int bonusPoints, int amountCompleted, int desiredAmount) : base (name, description, points, completionStatus)
    {
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
        _desiredAmount = desiredAmount;
    }
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetDisplayString()
    {
        return base.GetDisplayString();
    }
}