using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity List.
        List<Activity> activities = new List<Activity>();

        // Running Activity.
        DateTime runningDate = new DateTime(2019, 4, 28);
        Running running = new Running(runningDate, 30, 3);
        activities.Add(running);

        // Cycling Activity.
        DateTime cyclingDate = new DateTime(2021, 7, 16);
        Cycling cycling = new Cycling(cyclingDate, 20, 0.5);
        activities.Add(cycling);

        // Swimming Activity.
        DateTime swimmingDate = new DateTime(2022, 9, 5);
        Swimming swimming = new Swimming(swimmingDate, 120, 5);
        activities.Add(swimming);

        // Get the summary of each Activity.
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}