public class Reception : Event
{
    private string _register;

    Reception(string title, string description, DateTime date, Address address, string register) : base(title, description, date, address)
    {
        _register = register;
    }

    
}