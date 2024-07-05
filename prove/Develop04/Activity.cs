using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

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
        Console.WriteLine();   
        Console.WriteLine($"{_description}");
        Console.WriteLine();   
    
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string frames = @"/-\|";

        Console.CursorVisible = false;

        for(int i = seconds; i > 0; i--)
        {
            foreach(var c in frames)
            {
                Console.Write($"\b{c}");
                Thread.Sleep(300);
            }
        }
    }
}