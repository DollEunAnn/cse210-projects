using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session?");
        int duration = Int32.Parse(Console.ReadLine());       
        
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        Console.WriteLine();
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("////");
    }
}