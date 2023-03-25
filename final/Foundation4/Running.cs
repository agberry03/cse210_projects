public class Running : Activity
{
    private double _distance;
    
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round((_distance / GetMinutes()) * 60, 1);
    }
    public override double GetPace()
    {
        return Math.Round(GetMinutes()  / _distance, 1);
    }
}