using System;
using System.Diagnostics;

// Math.Round() https://www.google.com/search?q=c%23+roundoff+to+tens+decimal&oq=c%23+roundoff+to+tens+decimal&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIGCAEQRRg60gEJMTA3MzVqMGo3qAIIsAIB&sourceid=chrome&ie=UTF-8
class Activity
{
    private string _date;
    private string _activityName;
    protected double _length;

    public Activity(string date, string activityName, double length)
    {
        _date = date;
        _activityName = activityName;
        _length = length;
    }

    public virtual double Distance()
    {
        return 0;

    }

    public virtual double Speed()
    {
        return 0;

    } 

    public virtual double Pace()
    {
        return 0;

    }

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_length} min) - Distance {Math.Round(Distance(),2)} km, Speed {Math.Round(Speed(),2)} kph, Pace: {Math.Round(Pace(),2)} min per km";
    }
}