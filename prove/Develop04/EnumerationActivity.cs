public class EnumerationActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _counter = 0;

    public EnumerationActivity()
    {
        SetDescription(
            "This activity will help you reflect on the " +
            "good things in your life by having you list " +
            "as many things as you can in a certain area.");
        SetName("Listing");
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int index;

        index = rand.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void DisplayPromptWait()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.Write("You may begin in: ");
        Counter(5);
    }

    public void GetInput()
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        Console.WriteLine();

        while (currentTime < CountDown(startTime))
        {
            Console.Write("> ");
            Console.ReadLine();
            CountInputs();
            currentTime = DateTime.Now;
        }
    }

    public void GetCountedItems()
    {
        Console.WriteLine($"You listed {_counter} item(s)!");
    }

    public void CountInputs()
    {
        _counter++;
    }

    public void RunEnumeration()
    {
        StartMessage();
        GetDuration();
        GetReadyMessage();
        DisplayPromptWait();
        GetInput();
        GetCountedItems();
        EndMessage();
    }
}