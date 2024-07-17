using System;

class LectureEvent : Event
{
    private string _speaker;
    private int _limitedCapacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int limitedCapacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;

    }

    /**
    Displays the full details of the lecture event
    **/
    public string DisplayLectureDetails()
    {
        
        return "";
    }  
    
}