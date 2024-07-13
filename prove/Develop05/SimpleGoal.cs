using System;

class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
         _isComplete = true;

    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string if_completed = IsCompleted() ? "[X]" : "[ ]";
        return $"{if_completed} {_name} ({_description})";
    }

}