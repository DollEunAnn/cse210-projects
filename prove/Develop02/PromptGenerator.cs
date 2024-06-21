using System;

// Accessing string list in random web link reference: https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable
public class PromptGenerator
{
    public List<int> _usedPrompts = new List<int>();
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made you smile today?",
        "What favorite meal today?",
        "How was the weather today?",
        "What something new you learned today?",
        "Did you talk to Heavenly Father today?",
    };

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
}