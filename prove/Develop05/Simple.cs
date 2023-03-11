public class Simple : Goal
{
    public Simple(string type, string name, string description, int points, bool isCompleted) : base(type, name, description, points, isCompleted)
    {
    }

    public override void info()
    {
        Console.WriteLine($"Name: {_name}");
    }
    public override int recordEvent()
    {
        if (_isCompleted == false)
        {
            _isCompleted = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool checkIfCompleted()
    {
        return _isCompleted;
    }
}