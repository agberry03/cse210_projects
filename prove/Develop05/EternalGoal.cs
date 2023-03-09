public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {base.RecordEvent()} points!");
        return base.RecordEvent();
    }
    public override bool IsComplete()
    {
        return false;
    }
}