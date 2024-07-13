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

    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string if_completed;

        if (IsCompleted())
        {
            if_completed = "[X]";

        }
        else
        {
            if_completed = "[ ]";

        }

        return $"{if_completed} {_name} ({_description})";
    }

}