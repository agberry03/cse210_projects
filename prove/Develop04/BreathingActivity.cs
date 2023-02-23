public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetDescription(
            "This activity will help you relax by walking " +
            "you through breathing in and out slowly. " +
            "Clear your mind and focus on your breathing.");
        SetName("Breathing");
    }

    public void BreatheCycle()
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        while (currentTime < CountDown(startTime))
        {
            Console.Write("Breath in...");
            Counter(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            Counter(6);
            Console.WriteLine();

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
        GetReadyMessage();
        BreatheCycle();
        EndMessage();
    }
}