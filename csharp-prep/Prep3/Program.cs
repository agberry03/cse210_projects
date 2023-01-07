using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int guessNum = -1;

        List<int> guessList = new List<int>() {};
        string answer = "yes";
    
        while (answer.ToLower() == "yes")
        {
            while (guessNum != magicNum)
            {
                Console.Write("What is your guess? ");
                guessNum = int.Parse(Console.ReadLine());
                
                if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                    guessList.Add(guessNum);
                }
                else if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                    guessList.Add(guessNum);
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessList.Add(guessNum);
                    Console.WriteLine($"You guessed it in {guessList.Count} tries.");
                }
            }
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();

            guessList.Clear();
            magicNum = randomGenerator.Next(1, 100);
        }
    }
}