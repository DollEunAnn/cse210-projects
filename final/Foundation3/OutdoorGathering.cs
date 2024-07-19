using System;
using System.Text;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;

    }

    public string OutdoorGatheringDetails()
    {
        return $"Weather Forecast: {_weatherForecast}";
    }  

}