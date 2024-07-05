using System;

class ListingActivity : Activity
{
    private int _count;
    private List<int> _usedPrompts = new List<int>();

    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string name="Listing Activity", string description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", int duration = 10) : base(name,description,duration)
    {

    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");

        GetRandomPrompt();

        Console.WriteLine();
        Console.Write("You may begin in: ");
        for(int j = 5; j > 0; j--) // countdown
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        _count = GetListFromUser().Count();

        Console.WriteLine($"You listed {_count} items");       
    }

    public void GetRandomPrompt()
    {
        Random _randomPrompt = new Random();

        int index = 0;

        do
        {
            index = _randomPrompt.Next(_prompts.Count);

        } while (_usedPrompts.Contains(index));

        _usedPrompts.Add(index);

        Console.WriteLine($"{_prompts[index]}");

    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        List<string> answers = new List<string>();

        while(DateTime.Now < futureTime )
        {
            Console.Write("\n> ");
            string input = Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            {
                answers.Add(input);
            }

        } 

        return answers;               
    }  
}