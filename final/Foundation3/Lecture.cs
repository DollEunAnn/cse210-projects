using System;
using System.Text;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public string LectureDetails()
    {

        StringBuilder details = new StringBuilder();

        details.AppendLine($"Speaker: {_speaker}");
        details.AppendLine($"Capacity: Limited to {_capacity}.");

        return details.ToString();
    }  
    
}