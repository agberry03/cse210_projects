public class Reception : Event
{
    private string _register;

    public Reception(string title, string description, DateTime date, Address address, string register) : base(title, description, date, address)
    {
        _register = register;
    }

    public override void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Register: {_register}");
    }
}