using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Eunice","Inheritance");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","European History", "The Cause of World War II");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}