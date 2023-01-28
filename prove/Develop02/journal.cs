public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetPrompt();

        Console.WriteLine(randomPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry(randomPrompt, response);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void Load()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Entry> entries = new List<Entry>(); 
        foreach (string line in lines)
        {
            string[] parts = line.Split("::");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(date, prompt, response);
            entries.Add(entry);
        }
        _entries = entries;
        Console.WriteLine($"File {fileName} loaded.");
    }

    public void Save()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Save());
            }
        }
        Console.WriteLine($"File {fileName} saved.");
    }
}