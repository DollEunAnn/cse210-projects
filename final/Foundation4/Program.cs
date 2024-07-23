using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>();
        
        Running running = new Running("22 July 2024", "Running", 10, 25);
        activities.Add(running);

        StationaryBicycle stationaryBicycle = new StationaryBicycle("23 July 2024", "StationaryBicycle", 20, 35);
        activities.Add(stationaryBicycle);

        Swimming swimming = new Swimming("24 July 2024", "Swimming", 60, 45);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());            
        }

        Console.WriteLine();
    }
}