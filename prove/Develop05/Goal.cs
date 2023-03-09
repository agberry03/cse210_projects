public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsEarned;

    public Goal(string name, string description, int pointsEarned)
    {
        _name = name;
        _description = description;
        _pointsEarned = pointsEarned;
    }

    public virtual int RecordEvent()
    {
        return _pointsEarned;
    }
    public abstract bool IsComplete();
    public virtual string GetDisplayString()
    {
        string box;

        if (IsComplete())
        {
            box = "[x]";
        }
        else
        {
            box = "[ ]";
        }
        return $"{box} {_name} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_pointsEarned}";
    }
    public string GetGoalName()
    {
        return _name;
    }
}