public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetPrompt();
        string acceptPrompt = "";
        
        Console.WriteLine();

        // Continue giving different prompts until the user selects "Y".
        while (acceptPrompt.ToLower() != "y")
        {
            Console.WriteLine(randomPrompt);
            Console.Write("Accept this prompt? Y/N: ");
            acceptPrompt = Console.ReadLine();

            if (acceptPrompt.ToLower() == "y")
            {
                Console.WriteLine();
                Console.WriteLine("Prompt accepted.");
                Console.WriteLine(randomPrompt);
            }
            else if (acceptPrompt.ToLower() == "n")
            {
                Console.WriteLine();
                Console.WriteLine("New prompt:");
                randomPrompt = promptGenerator.GetPrompt();
            }
            else
            {
                Console.WriteLine("Please enter 'Y' or 'N'.");
            }
        }

        Console.Write("> ");
        string response = Console.ReadLine();
        Entry entry = new Entry(randomPrompt, response);
        _entries.Add(entry);

        Console.WriteLine();
        Console.WriteLine("Response recorded. Be sure to save before quitting!");
        Console.WriteLine();
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        Console.WriteLine("Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void Load()
    {
        Console.WriteLine();
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
        Console.WriteLine();
    }

    public void Save()
    {
        Console.WriteLine();
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
        Console.WriteLine();
    }
}