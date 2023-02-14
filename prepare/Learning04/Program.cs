using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "Math");
        Console.WriteLine(assignment.GetSummery());

        MathAssignment mathAssignment = new MathAssignment("John", "Math", "Chapter 1", "1, 2, 3");
        Console.WriteLine(mathAssignment.GetSummery());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("John", "English", "The Great Gatsby");
        Console.WriteLine(writingAssignment.GetSummery());
        Console.WriteLine(writingAssignment.GetWritingINformation());


        
    }
}