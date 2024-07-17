using System;

class ReceptionEvent : Event
{
    private string _emailReservation;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string emailReservation) : base(title, description, date, time, address)
    {
        _emailReservation = emailReservation;

    }

    public string EventType()
    {
        return $"Reception";
    }

    /**
   Displays the full details of the Reception event
   **/
    public string DisplayReceptionDetails()
    {
        return "";
    }
}