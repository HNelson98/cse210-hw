public abstract class Goal
{
    protected string _version;
    protected string _name;
    protected string _discription;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string type, string name, string description, int points, bool isCompleted)
    {
        _version = type;
        _name = name;
        _discription = description;
        _points = points;
        _isCompleted = isCompleted;
    }
    public string getName()
    {
        return _name;
    }
    public string getDescription()
    {
        return _discription;
    }
    public int getPoints()
    {
        return _points;
    }
    public bool getIsCompleted()
    {
        return _isCompleted;
    }

    public string version()
    {
        return _version;
    }
    
    public abstract void info();
    public abstract int recordEvent();
    public abstract bool checkIfCompleted();
}
