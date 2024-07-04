using System;

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
class BreathingActivity : Activity
{
    public BreathingActivity(string name = "Breathing Activity", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", int duration = 10) : base(name,description,duration)
    {
               
    }

    public void Run()
    {
        

    }
    
}