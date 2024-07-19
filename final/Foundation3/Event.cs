using System;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

// Reference for space between words: https://stackoverflow.com/questions/272633/add-spaces-before-capital-letters

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
        details.Append($"Address: {_address.CompleteAddress()}");

        return details.ToString();
    }

    public string DisplayEventShortDetails(string type)
    {
        StringBuilder details = new StringBuilder();

        string newValue = Regex.Replace(type, "([a-z])([A-Z])", "$1 $2");

        details.AppendLine($"Type of Event: {newValue}");
        details.AppendLine($"Title: {_title}");
        details.AppendLine($"Date: {_date}");

        return details.ToString();
    }     
}