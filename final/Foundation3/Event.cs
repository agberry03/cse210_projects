public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public void GetStandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\nOn {_date.ToShortDateString()} {_date.ToShortTimeString()} at {_address.GetAddressString()}");
    }
    public virtual void GetFullDetails()
    {
        GetStandardDetails();
    }
    public void GetShortDescription()
    {
        Console.WriteLine($"{GetType()}\n{_title} - {_date.ToShortDateString()}");
    }
}