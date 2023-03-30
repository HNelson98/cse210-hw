public class Attack
{
    string _name;
    int _power;
    int _range;
    int _uses;

    public Attack(string name, int power, int range, int uses)
    {
        _name = name;
        _power = power;
        _range = range;
        _uses = uses;
    }

    public string getName()
    {
        return _name;
    }

    public int getPower()
    {
        return _power;
    }

    public int getRange()
    {
        return _range;
    }

    public int getUses()
    {
        return _uses;
    }
}