using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the time when the program starts.
        TimeSpan startTime = DateTime.Now.TimeOfDay;

        // Opening message and response initialization.
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following options.");
        string response = "";
        Journal journal = new Journal();

        while (response != "5")
        {
            // Option selection menu.
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save");
            Console.WriteLine("5: Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {
                journal.AddEntry();
            }
            else if (response == "2")
            {
                journal.DisplayAll();
            }
            else if (response == "3")
            {
                journal.Load();
            }
            else if (response == "4")
            {
                journal.Save();
            }
            else if (response != "5")
            {
                Console.WriteLine("Invalid entry. Please type a number between 1-5.");
            }
        }

        // Get the time when the user exits.
        TimeSpan endTime = DateTime.Now.TimeOfDay;

        // Get the total time the program ran, get the duration 
        // of totalTime, and convert it to total minutes.
        TimeSpan totalTime = (endTime - startTime);
        totalTime = totalTime.Duration();
        double totalMinutes = totalTime.TotalMinutes;

        // Display total minutes spent in the journal program this session.
        // Display a special message if the user spent less than 1 minute writing.
        if (totalMinutes < 1)
        {
            Console.WriteLine();
            Console.WriteLine("Wow, you spent less than a minute writing! Keep it up!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"You only had to spend {Math.Round(totalMinutes)} "
                            + "minutes of your time writing. Keep it up!");
        }
        // Press enter to leave the program.
        Console.Write("Press ENTER to exit the program: ");
        Console.ReadLine();
    }
}