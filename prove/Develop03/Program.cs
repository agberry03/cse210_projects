using System;
/*
 I showed creativity and exceeded requirements by
 adding logic to the HideWords method in the Scripture
 class to prevent the same word in a scripture from being hidden again.
 I also added a difficulty prompt so that the user can input the
 number argument for HideWords.
*/

class Program
{
    static void Main(string[] args)
    {
        /* Original scripture I used.

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,
            "For God so loved the world, that " +
            "he gave his only begotten Son, that " +
            "whosoever believeth in him should not " +
            "perish, but have everlasting life.");

        */

        // Scripture I am now using, to test _endVerse and large HideWord calls.
        Reference reference = new Reference("Enos", 1, 4, 9);
        Scripture scripture = new Scripture(reference,

            "And my soul hungered; and I kneeled " +
            "down before my Maker, and I cried unto " +
            "him in mighty prayer and supplication " +
            "for mine own soul; and all the day long " +
            "did I cry unto him; yea, and when the " +
            "night came I did still raise my voice high " +
            "that it reaced the heavens. " +

            "And there came a voice unto me, " +
            "saying: Enos, thy sins are forgiven thee, " +
            "and thou shalt be blessed. " +

            "And I, Enos, knew that God could not " +
            "lie; wherefore, my guilt was swept away. " +

            "And I said: Lord, how is it done? " +

            "And he said unto me: Because of thy " +
            "faith in Christ, whom thou hast never " +
            "before heard nor seen. And many years " +
            "pass away before he shall manifest " +
            "himself in the flesh; wherefore, go to, thy " +
            "faith hath made thee whole.");


        // Initialize input.
        string input;

        // Initialize and assign word count.
        int wordCount = 0;

        foreach (string word in scripture.GetDisplayText().Split(" ")) {
            wordCount ++;
        }

        // Welcome message.
        Console.WriteLine("Welcome to the Scripture Memorizer program!");

        // Blank line.
        Console.WriteLine();

        // Prompt for the difficulty.
        Console.Write("Enter the difficulty (The number of items removed on each round): ");

        // Get difficulty from user.
        // Continue to get input until the user enters a valid number.
        // Change difficulties greater than wordCount to wordCount.
        int difficulty;
        do {
            difficulty = int.Parse(Console.ReadLine());
            if (difficulty < 1) {
                Console.Write("Invalid entry. Please enter a number 1 or greater: ");
            }
            if (difficulty > wordCount) {
                difficulty = wordCount;
            }
        }
        while (difficulty < 1);
        

        do
        {
            Console.Clear();

            // Initialize scriptureText.
            string scriptureText = scripture.GetDisplayText();

            // Display scripture.
            Console.WriteLine(scriptureText);

            // Blank line.
            Console.WriteLine();

            // Input message.
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            // User input.
            input = Console.ReadLine();
            
            // Leave the loop if the entire scripture is hidden.
            if (scripture.IsCompletelyHidden()) {
                break;
            }

            // Hide words based on the difficulty input.
            scripture.HideWords(difficulty);

            Console.Clear();
        }

        while (input.ToLower() != "quit");

        // Goodbye message.
        Console.WriteLine("Goodbye!");
    }
}