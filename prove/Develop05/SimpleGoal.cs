public class SimpleGoal : Goal
{
    private bool _complete = false;

    public SimpleGoal(string name, string description, int pointsEarned) : base(name, description, pointsEarned)
    {

    }
    public SimpleGoal(string name, string description, int pointsEarned, bool complete) : base(name, description, pointsEarned)
    {
        _complete = complete;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal has already been completed!");
            return 0;
        }
        else
        {
            _complete = true;
            Console.WriteLine($"Congratulations! You have earned {base.RecordEvent()} points!");
            return base.RecordEvent();
        }
    }
    public override bool IsComplete()
    {
        return _complete;
    }
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_complete}";
    }
}