public class ChecklistGoal : Goal
{
    private int _desiredAmount;
    private int _completedAmount;
    private int _bonusEarned;

    public ChecklistGoal(string name, string description, int points, int desiredAmount, int bonusPoints) : base(name, description, points)
    {
        _bonusEarned = bonusPoints;
        _desiredAmount = desiredAmount;
    }
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int desiredAmount, int completedAmount) : base(name, description, points)
    {
        _bonusEarned = bonusPoints;
        _desiredAmount = desiredAmount;
        _completedAmount = completedAmount;
    }

    public override int RecordEvent()
    {
        if (_completedAmount == _desiredAmount - 1)
        {
            _completedAmount++;
            Console.WriteLine($"Congratulations! You have earned {base.RecordEvent() + _bonusEarned} points!");
            return _bonusEarned + base.RecordEvent();
        }
        else
        {
            _completedAmount++;
            Console.WriteLine($"Congratulations! You have earned {base.RecordEvent()} points!");
            return base.RecordEvent();
        }
    }
    public override bool IsComplete()
    {
        return _completedAmount == _desiredAmount;
    }
    public override string GetDisplayString()
    {
        return $"{base.GetDisplayString()} -- Currently completed: {_completedAmount}/{_desiredAmount}";
    }
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_bonusEarned},{_desiredAmount},{_completedAmount}";
    }
}