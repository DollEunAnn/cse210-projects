using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        // nothing to be completed
        // keeps recoding the score
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_name} ({_description})";
    }

    public override string GetStringSave()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }

    public override int GetPoints()
    {
        return _points;
    }

}