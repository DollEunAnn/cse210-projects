using System;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public abstract void RecordEvent();

    public abstract bool IsCompleted();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();  
}