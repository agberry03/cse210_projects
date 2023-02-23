public class Activity
{
    private int _duration;
    private string _description;
    private string _name;

    public Activity()
    {
        _duration = 60;
        _description = "description placeholder";
        _name = "name placeholder";
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void EndMessage()
    {
        Console.WriteLine($"\nWell done!!");
        Spinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(5);
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n");
    }

    public void GetReadyMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(5);
        Console.WriteLine();
    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }

    public DateTime CountDown(DateTime start)
    {
        DateTime futureTime = start.AddSeconds(_duration);
        return futureTime;
    }

    public void Counter(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int waitSeconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "—",
            "\\",
            "|",
            "/",
            "—",
            "\\"
        };

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(waitSeconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= 8)
            {
                i = 0;
            }
        }
    }
}