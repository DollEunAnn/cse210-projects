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
        // set the goal - completed
        // then add points to the current 
        _isComplete = true;

    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_name} ({_description})";
    }

    public override string GetStringSave()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }

    public override int GetPoints()
    {
        return _points;
    }



}