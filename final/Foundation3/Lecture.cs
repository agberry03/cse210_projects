public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity) : base(title, description, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void GetFullDetails()
    {

    }
}