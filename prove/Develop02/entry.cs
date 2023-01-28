public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = DateTime.Now.ToString("MM/dd/yyyy");

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
    }

    public Entry(string date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string Save()
    {
        string entryData = $"{_date}::{_prompt}::{_response}";
        return entryData;
    }

    public void Display()
    {
        string formattedEntry = $"Date: {_date} - Prompt: {_prompt}\n{_response}\n";
        Console.WriteLine(formattedEntry);
    }
}