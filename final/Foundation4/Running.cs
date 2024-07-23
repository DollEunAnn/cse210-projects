using System;

class Running : Activity
{
    private double _distance;

    public Running(string date, string activityName, int length, double distance) : base (date, activityName, length)
    {
        _distance = distance;

    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double speed = _distance/_length * 60.0;
        
        return speed;
    }

    public override double Pace()
    {
        double pace = _length / _distance;

        return pace;
    }
}