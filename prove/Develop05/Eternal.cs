public class Eternal : Goal
{
    public Eternal(string type, string name, string description, int points, bool isCompleted) : base(type, name, description, points, isCompleted)
    {
    }

    public override void info()
    {
        Console.WriteLine($"Name: {_name}");
    }
    public override int recordEvent()
    {
        return _points;
    }

    public override bool checkIfCompleted()
    {
        return _isCompleted;
    }
}