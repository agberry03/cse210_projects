public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }
    
    public override double GetDistance()
    {
        return Math.Round((_laps * 50) / (1000 * 0.62), 1);
    }
    public override double GetSpeed()
    {
        return Math.Round(GetPace() * 60, 1);
    }
    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 1);
    }
}