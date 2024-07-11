using System;

class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
    
}