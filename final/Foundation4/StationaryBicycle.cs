using System;

class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(string date, string activityName, int length, double speed) : base (date, activityName, length)
    {
        _speed = speed;

    }

    public override double Distance()
    {
        double distance = _speed * _length * 60;
        return distance;
    }

    public override double Speed()
    {        
        return _speed;
    }

    public override double Pace()
    {
        double pace = 60 / _speed;

        return pace;
    }
    
}