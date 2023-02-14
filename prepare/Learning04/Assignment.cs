public class  Assignment
{

protected string studentName;
string _topic;

public Assignment(string Name, string topic)
{
    studentName = Name;
    _topic = topic;
}

public string GetSummery()
{
    return $"{studentName} - {_topic}";
}

public string GetStudentName()
{
    return studentName;
}

}

