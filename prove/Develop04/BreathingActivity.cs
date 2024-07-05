using System;

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers

class BreathingActivity : Activity
{

    public BreathingActivity(string name = "Breathing Activity", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", int duration = 10) : base(name,description,duration)
    {

    }

    public void Run()
    {          
        int userDuration = _duration;
        int breathDuration = 10; // 4 + 6
        int cycle = userDuration / breathDuration;
        
        for(int i = 0; i < cycle; i++)
        {
            Console.WriteLine();

            // breath in - 4     
            Console.Write("Breathe in...");
            for(int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();    

            // breath out - 6
            Console.Write("Breathe Out...");
            for(int l = 6; l > 0; l--)
            {
                Console.Write(l);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

        }
        
        


    }
    
}