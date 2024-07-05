using System;

class ReflectingActivity : Activity
{
    private List<int> _usedPrompts = new List<int>();
    
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    List<string> _questions = new List<string>
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
        return " ";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }

    
    
}