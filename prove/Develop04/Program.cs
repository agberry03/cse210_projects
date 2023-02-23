using System;

/*
    I showed creativity and exceeded requirements by adding extra functionality to
    the BreathingActivity class. The user now picks a breathing pattern to follow,
    and the time spent inhaling, exhaling, and holding breath changes
    to reflect this choice.
*/

class Program
{
    static void Main(string[] args)
    {
        // Initialize input.
        string input = "";

        // Initialize activities.
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        EnumerationActivity enumerationActivity = new EnumerationActivity();

        // Continue while "quit" has not been selected.
        while (input != "4")
        {
            // Clear console when program starts or activity is complete.
            Console.Clear();

            // Menu screen.
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"\t1. Start breathing activity");
            Console.WriteLine($"\t2. Start reflecting activity");
            Console.WriteLine($"\t3. Start listing activity");
            Console.WriteLine($"\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get user input.
            input = Console.ReadLine();

            // Run the breathing activity.
            if (input == "1")
            {
                breathingActivity.RunBreathing();
            }

            // Run the reflection activity.
            else if (input == "2")
            {
                reflectionActivity.RunReflection();
            }

            // Run the listing(enumeration) activity.
            else if (input == "3")
            {
                enumerationActivity.RunEnumeration();
            }

            // If the input is not any of the menu options,
            // print a message before looping back.
            else if (input != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Press enter and try again.");
                Console.ReadLine();
            }
        }

        // Goodbye message.
        Console.WriteLine();
        Console.WriteLine("Goodbye.");
    }
}