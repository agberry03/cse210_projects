public class ReflectionActivity : Activity
{
    public List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        SetDescription(
            "This activity will help you reflect on times " +
            "in your life when you have shown strength " +
            "and resilience. This will help you recognize " +
            "the power you have and how you can use it in " +
            "other aspects of your life.");
        SetName("Reflection");
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int index;

        index = rand.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetQuestion()
    {
        Random rand = new Random();
        int index;

        index = rand.Next(0, _questions.Count);
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void WaitPonder()
    {
        Console.WriteLine("Now ponder each of the following " +
            "questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Counter(5);
        Console.Clear();
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetQuestion()} ");
    }

    public void AnswerSpin()
    {
        Spinner(10);
        Console.Write($"\n");
    }

    public void ReflectionCycle()
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        while (currentTime < CountDown(startTime))
        {
            DisplayQuestion();
            AnswerSpin();
            currentTime = DateTime.Now;
        }
    }

    public void RunReflection()
    {
        StartMessage();
        GetDuration();
        GetReadyMessage();
        DisplayPrompt();
        WaitPonder();
        ReflectionCycle();
        EndMessage();
    }
}