public class Ranger : Charachter
{
    public Ranger(string name) : base(name, 150, 15, "Ranger")
    {
        addAttack();
    }

    public override void addAttack()
    {
        _attacks.Add(new Attack("Shoot Arrow", 20, 100, 10));
        _attacks.Add(new Attack("Slash", 15, 5, 15));
        _attacks.Add(new Attack("Stab", 20, 5, 20));
    }
}