using System;

class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, string activityName, int length, int numberOfLaps) : base (date, activityName, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        double distance = _numberOfLaps * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {        
        double speed = Distance() / _length * 60;

        return speed;
    }

    public override double Pace()
    {
        double pace = 60 / Speed();

        return pace;
    }


    
}