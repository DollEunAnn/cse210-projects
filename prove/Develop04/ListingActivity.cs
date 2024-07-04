using System;

class ListingActivity : Activity
{
    private int _count;
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
        

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {

        return _prompts;
    }


    
}