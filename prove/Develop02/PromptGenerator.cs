using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
     {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made you smile today?",
        "What favorite meal today?",
        "How was the weather today?"
    };


    public string GetRandomPrompt()
    {
        Random _randomPrompt = new Random();
        
        int index = _randomPrompt.Next(_prompts.Count);

        return _prompts[index];
    }

}