using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        // all at the amount complete e.g. [0/2] => [1/2]
        _amountCompleted++;
        IsCompleted();

    }

    public override bool IsCompleted()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringSave()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";

    }

    public override int GetPoints()
    {
        // checks if the amountCompleted GREATER to target
        // if true - apply bonus
        if (_amountCompleted > _target)
        {
            return _bonus + _points;
        }
        else
        {
            return _points;
        }

    }

}