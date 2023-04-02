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
    public void attack(int distance, Charachter target)
    {
        Console.WriteLine("Which attack would you like to use?");
        int i = 0;
        foreach (Attack attack in _attacks)
        {
            Console.WriteLine("     " + i + ": " + attack.getName());
            i++;
        }
        int attackChoice = Convert.ToInt32(Console.ReadLine());
        if (attackChoice < _attacks.Count)
        {
            if (_attacks[attackChoice].getUses() > 0)
            {
                if (distance <= _attacks[attackChoice].getRange())
                {
                    _attacks[attackChoice].use();
                    int toHit = new Random().Next(1, 25);
                    Console.WriteLine("You rolled a " + toHit + " to hit.");
                    if (toHit > target.getArmorPoints())
                    {
                        int damage = _attacks[attackChoice].getPower();
                        Console.WriteLine("You hit for " + damage + " damage.");
                        target._health -= damage;
                        Console.WriteLine(target.getName() + " has " + target.getHealth() + " health left.");
                        Console.WriteLine(_attacks[attackChoice].getName() + " has " + _attacks[attackChoice].getUses() + " uses left.");
                    }
                    else
                    {
                        Console.WriteLine("You missed.");
                    }
                }
                else
                {
                    Console.WriteLine("That attack is out of range.");
                }
            }
            else
            {
                Console.WriteLine("That attack is out of uses.");
            }
        }  
    }
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