using System;

class Reception : Event
{
    private string _emailReservation;

    public Reception(string title, string description, string date, string time, Address address, string emailReservation) : base(title, description, date, time, address)
    {
        _emailReservation = emailReservation;

    }

    public string ReceptionDetails()
    {
        return $"Email for RSVP: {_emailReservation}";
    }
}