using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        bool done = false;
        while (!done)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (input == "0")
            {
                done = true;
            } else
            {
                int number = int.Parse(input);
                numbers.Add(number);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The total is: {total}");

        int average = total / numbers.Count();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        
        Console.WriteLine($"The highest number is: {max}");



    }
}