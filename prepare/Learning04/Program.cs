using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Eunice","Inheritance");

        Console.WriteLine(assignment.GetSummary());
    }
}