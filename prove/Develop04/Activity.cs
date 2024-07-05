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
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());       
    
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
        string frames = @"/-\|";

        Console.WriteLine("Get ready...");
        Console.CursorVisible = false;

        for(int i = seconds; i > 0; i--)
        {
            foreach(var c in frames)
            {
                Console.Write($"\b{c}");
                Thread.Sleep(300);
            }
        }



            





        // for(int i = seconds; i > 0; i--)
        // {
        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("/"); // Replace it with the - character
        //     Thread.Sleep(300);
        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("-"); // Replace it with the - character
        //     Thread.Sleep(300);
        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("\\"); // Replace it with the - character
        //     Thread.Sleep(300);
        //     Console.Write("\b \b"); // Erase the + character
        //     Console.Write("|");
        //     Thread.Sleep(300);
        // };

        Console.WriteLine("Go ~");
    }
}