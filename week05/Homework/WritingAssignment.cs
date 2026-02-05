public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Direct access is now possible because of the 'protected' keyword
        return $"{_title} by {_studentName}";
    }
}