using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}