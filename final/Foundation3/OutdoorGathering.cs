public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, Address address, string weather) : base(title, description, date, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}