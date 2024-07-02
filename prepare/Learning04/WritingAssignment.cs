using System;

class WritingAssignment : Assignment
{    
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // returned the _studentName in Assignment.cs to privated the created a method GetStudentName
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}