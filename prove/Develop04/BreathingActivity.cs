public class BreathingActivity : Activity
{
    // Variables for different breathing patterns.
    private int _breatheIn;
    private int _breatheOut;
    private int _holdBreath1;
    private int _holdBreath2;

    public BreathingActivity()
    {
        // Edited description.
        SetDescription(
            "This activity will help you relax by walking " +
            "you through breathing in and out slowly, holding your breaths when prompted. " +
            "Clear your mind and focus on your breathing.");
        SetName("Breathing");
    }

    // Have the user choose a breathing pattern to follow.
    public string BreathingPrompt()
    {
        string input = "";
        while (!(new List<string> { "1", "2", "3", "4" }.Contains(input)))
        {
            Console.Clear();
            Console.WriteLine("What kind of breathing would you like to do?");
            Console.WriteLine($"\t1. 4-7-8 breathing");
            Console.WriteLine($"\t2. 4-2-4 breathing");
            Console.WriteLine($"\t3. Box breathing");
            Console.WriteLine($"\t4. HRV breathing");
            Console.Write("Select one of the options above: ");
            input = Console.ReadLine();

            if (!(new List<string> { "1", "2", "3", "4" }.Contains(input)))
            {
                Console.WriteLine("Invalid input. Press enter and try again.");
                Console.ReadLine();
            }
        }
        Spinner(3);
        return input;
    }

    // Set the variables base on the response from BreathingPrompt.
    public void SetBreathing()
    {
        string breathePattern = BreathingPrompt();

        if (breathePattern == "1")
        {
            _breatheIn = 4;
            _holdBreath1 = 7;
            _breatheOut = 8;
            _holdBreath2 = 0;
        }
        else if (breathePattern == "2")
        {
            _breatheIn = 4;
            _holdBreath1 = 2;
            _breatheOut = 4;
            _holdBreath2 = 0;
        }
        else if (breathePattern == "3")
        {
            _breatheIn = 4;
            _holdBreath1 = 4;
            _breatheOut = 4;
            _holdBreath2 = 4;
        }
        else
        {
            _breatheIn = 6;
            _holdBreath1 = 0;
            _breatheOut = 6;
            _holdBreath2 = 0;
        }
    }

    // The breathing pattern that will be used in BreathingCycle.
    public void BreathePattern()
    {
        Console.Write("Breath in...");
        Counter(_breatheIn);
        Console.WriteLine();

        if (_holdBreath1 != 0)
        {
            Console.Write("Hold...");
            Counter(_holdBreath1);
            Console.WriteLine();
        }

        Console.Write("Now breath out...");
        Counter(_breatheOut);
        Console.WriteLine();

        if (_holdBreath2 != 0)
        {
            Console.Write("Hold again...");
            Counter(_holdBreath2);
            Console.WriteLine();
        }
    }

    public void BreatheCycle()
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        while (currentTime < CountDown(startTime))
        {
            BreathePattern();

            currentTime = DateTime.Now;
            if (currentTime >= CountDown(startTime))
            {
                break;
            }
            Console.WriteLine();
        }
    }

    public void RunBreathing()
    {
        StartMessage();
        GetDuration();
        SetBreathing();
        GetReadyMessage();
        BreatheCycle();
        EndMessage();
    }
}