using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade number? ");
        string gradeInput = Console.ReadLine();
        int gradeNum = int.Parse(gradeInput);

        string letter = "";
        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Grade: {letter}");
        
        if (gradeNum >= 70)
        {
            Console.WriteLine("You Passed! Good job!");
        }
        else
        {
            Console.WriteLine("You didn't pass...You'll get it next time!");
        }
    }
}