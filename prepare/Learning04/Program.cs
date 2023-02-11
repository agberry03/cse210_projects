using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");

        string summary1 = assignment1.GetSummary();
        Console.WriteLine(summary1);

        Console.WriteLine();

        // MathAssignment
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        
        string summary2 = assignment2.GetSummary();
        Console.WriteLine(summary2);

        string homeworkList2 = assignment2.GetHomeworkList();
        Console.WriteLine(homeworkList2);

        Console.WriteLine();

        // WritingAssignment
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        
        string summary3 = assignment3.GetSummary();
        Console.WriteLine(summary3);
        
        string paperName3 = assignment3.GetWritingInformation();
        Console.WriteLine(paperName3);
    }
}