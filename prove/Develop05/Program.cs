/*
I exceeded the core requirements and showed creativity by adding a
level up system to the program. The current level the user is at
and the number of points needed to level up again are displayed,
and when the user levels up they receive a message informing them.
The user's level and required points to level up are saved to the
file and can be loaded from it as well.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create GoalManager.
        GoalManager goalManager = new GoalManager();

        string input = "";

        while (input != "6")
        {
            // Display points.
            Console.WriteLine();
            goalManager.DisplayScore();
            Console.WriteLine();

            // Menu options list.
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"\t1. Create New Goal");
            Console.WriteLine($"\t2. List Goals");
            Console.WriteLine($"\t3. Save Goals");
            Console.WriteLine($"\t4. Load Goals");
            Console.WriteLine($"\t5. Record Event");
            Console.WriteLine($"\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get user input.
            input = Console.ReadLine();

            if (input == "1")
            {
                // Goal type selection.
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine($"\t1. Simple Goal");
                Console.WriteLine($"\t2. Eternal Goal");
                Console.WriteLine($"\t3. Checklist Goal");
                Console.Write($"Which type of goal would you like to create? ");

                // Goal type input.
                string goalTypeInput = Console.ReadLine();

                // Goal name.
                Console.Write("What is the name of the goal? ");
                string goalName = Console.ReadLine();

                // Goal description.
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                // Goal points.
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = int.Parse(Console.ReadLine());

                if (goalTypeInput == "1" || goalTypeInput == "2")
                {
                    // Create simple or eternal Goal.
                    goalManager.CreateGoal(goalTypeInput, goalName, goalDescription, goalPoints);
                }
                else if (goalTypeInput == "3")
                {
                    // Checklist goal count to bonus.
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int bonusTimes = int.Parse(Console.ReadLine());

                    // Bonus Points.
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    // Create Checklist Goal.
                    goalManager.CreateGoal(goalName, goalDescription, goalPoints, bonusTimes, bonusPoints);
                }
                else
                {
                    Console.Write("Invalid input. Press enter to return to the main menu: ");
                    Console.ReadLine();
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("The goals are:");
                // List Goals.
                goalManager.ShowGoalList();
            }
            else if (input == "3")
            {
                // Get filename
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                // Save file.
                goalManager.Save(filename);
            }
            else if (input == "4")
            {
                // Get filename.
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                // Load file.
                goalManager.Load(filename);
            }
            else if (input == "5")
            {
                // Record Event.
                Console.WriteLine("The goals are:");

                // List goals.
                goalManager.ShowGoalSelection();
                Console.Write("Which goal did you accomplish? ");

                // Input accomplished goal.
                int goalNumber = int.Parse(Console.ReadLine());

                // Record Event in GoalManager.
                goalManager.RecordEvent(goalNumber);
            }
            else if (input == "6")
            {
                Console.WriteLine();

                // Goodbye message.
                Console.WriteLine("Goodbye.");
            }
        }
    }
}