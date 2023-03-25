public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetSummary()
    {
        return $"{GetFormattedDate()} {GetType()} ({_minutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    public string GetFormattedDate()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        return formattedDate;
    }
    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}