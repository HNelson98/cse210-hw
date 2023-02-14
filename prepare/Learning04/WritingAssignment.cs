public class WritingAssignment : Assignment
{
    string _title;
    
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingINformation()
    {
        return $"{_title} by {studentName}";
    }
}