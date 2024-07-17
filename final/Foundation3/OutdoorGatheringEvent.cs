using System;

class OutdoorGatheringEvent : Event
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;

    }

    public string EventType()
    {
        return $"Outdoor Gathering";
    }

    /**
   Displays the full details of the OutDoorGathering event
   **/
    public string DisplayOutDoorGatheringDetails()
    {
        
        return "";
    }

}