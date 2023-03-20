public class OutdoorGathering : Event
{
    private string _weather;

    OutdoorGathering(string title, string description, DateTime date, Address address, string weather) : base(title, description, date, address)
    {
        _weather = weather;
    }
}