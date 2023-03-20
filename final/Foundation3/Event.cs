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
        
    }
    public virtual void GetFullDetails()
    {

    }
    public void GetShortDescription()
    {
        
    }
}