using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int input = -1;
        List<int> numbers = new List<int>() {};

        // Tell the user how the program functions.
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        // Ask for the user to input a number until they input '0'.
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            numbers.Add(input);
        }

        //remove '0' from 'numbers'.
       numbers.RemoveAt(numbers.Count - 1);

        // Print the sum of 'numbers'.
        Console.WriteLine($"The sum is: {numbers.Sum()}");

        // Print the average of 'numbers'.
        Console.WriteLine($"The average is: {numbers.Average()}");

        // Print the largest number in 'numbers'.
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}