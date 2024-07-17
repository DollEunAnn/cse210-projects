using System;
using System.Net.Sockets;
using System.Text;

class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayEventStandardDetails()
    {
        StringBuilder details = new StringBuilder();

        details.AppendLine($"Title: {_title}");
        details.AppendLine($"Date: {_date} - Time: {_time}");
        details.AppendLine($"Address: {_address.CompleteAddress()}");

        return details.ToString();
    }

    public string DisplayEventShortDetails()
    {
        StringBuilder details = new StringBuilder();


        return "";
    }     
}