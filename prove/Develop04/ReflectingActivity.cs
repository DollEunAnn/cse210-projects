using System;

class ReflectingActivity : Activity
{
    private List<int> _usedPrompts = new List<int>();
    private List<int> _usedQuestions = new List<int>();
    
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string name="Reflecting Activity", string description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", int duration = 10) : base(name,description,duration)
    {

    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        
        DisplayPrompt();
        
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        var key = Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        for(int j = 5; j > 0; j--) // countdown
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        // clear Console then Show Questions with Spinner
        Console.Clear();
        
        int userDuration = _duration;
        int questionDuration = 5;
        int cycle = userDuration / questionDuration;

        for(int i = 0; i < cycle; i++)
        {
            DisplayQuestion();
            Console.Write("\b");           
        }

    }

    public string GetRandomPrompt()
    {
        Random _randomPrompt = new Random();

        int index = 0;

        // Loop until get a unique prompt
        do
        {
            index = _randomPrompt.Next(_prompts.Count);

        } while (_usedPrompts.Contains(index)); // Checks if the index exist in the array _usedPrompts

        _usedPrompts.Add(index); // Adds the index to the list _usedPrompts

        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random _randomPrompt = new Random();

        int index = 0;

        do
        {
            index = _randomPrompt.Next(_questions.Count);

        } while (_usedQuestions.Contains(index));

        _usedQuestions.Add(index);

        return _questions[index];

    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");

    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();

        Console.Write($"> {question} ");
        ShowSpinner(5);
        Console.Write("\b \b");
        Console.WriteLine();

    }  
}