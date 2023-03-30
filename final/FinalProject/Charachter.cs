public abstract class Charachter
{
    protected string _name;
    protected int _id;
    protected static int _nextId = 0;
    protected int _health;
    protected int _armorPoints;
    protected string _class;

    protected List<Attack> _attacks = new List<Attack>();
    
    public Charachter(string name, int health, int armorPoints, string classType)
    {
        _name = name;
        _id = _nextId;
        _nextId++;
        _health = health;
        _armorPoints = armorPoints;
        _class = classType;
    }

    public abstract void addAttack();
    public void info()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("ID: " + _id);
        Console.WriteLine("Health: " + _health);
        Console.WriteLine("Armor Points: " + _armorPoints);
        Console.WriteLine("Class: " + _class);
        Console.WriteLine("Attacks: ");
        foreach (Attack attack in _attacks)
        {
            Console.WriteLine("     Name: " + attack.getName());
            Console.WriteLine("         Power: " + attack.getPower());
            Console.WriteLine("         Range: " + attack.getRange());
        }
    }
    public string getName()
    {
        return _name;
    }
    public int getHealth()
    {
        return _health;
    }
    public int getArmorPoints()
    {
        return _armorPoints;
    }
    public List<Attack> getAttacks()
    {
        return _attacks;
    }
    
}