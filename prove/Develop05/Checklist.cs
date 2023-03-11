public class Checklist : Goal
{
    int _bonus;
    int _timesCompleted;
    int _timesToComplete;
    public Checklist(string type, string name, string description, int points, int bonus, int timesToComplete, int timesCompleted, bool isCompleted) : base(type, name, description, points, isCompleted)
    {
        _bonus = bonus;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
    }

    public override void info()
    {
        Console.WriteLine($"Name: {_name} Times Completed: {_timesCompleted} / {_timesToComplete}");
    }

    public int getTimesCompleted()
    {
        return _timesCompleted;
    }

    public int getTimesToComplete()
    {
        return _timesToComplete;
    }

    public int getBonus()
    {
        return _bonus;
    }

    public override int recordEvent()
    {
        if (_isCompleted == true)
        {
            return 0;
        }
        _timesCompleted++;
        if (_timesCompleted >= _timesToComplete)
        {
            _isCompleted = true;
            return _points + _bonus;
        }
        return _points;
    }

    public override bool checkIfCompleted()
    {
        return _isCompleted;
    }
}