using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Adding a getter for the student name so derived classes can use it
    public string GetStudentName()
    {
        return _studentName;
    }
}