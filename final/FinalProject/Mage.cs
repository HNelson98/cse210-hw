public class Mage : Charachter
{
    public Mage(string name) : base(name, 100, 12, "Mage")
    {
        addAttack();
    }
    public override void addAttack()
    {
        _attacks.Add(new Attack("Fireball", 30, 100, 5));
        _attacks.Add(new Attack("Ice Shard", 20, 50, 7));
        _attacks.Add(new Attack("Lightning Bolt", 25, 200, 10));
    }
}