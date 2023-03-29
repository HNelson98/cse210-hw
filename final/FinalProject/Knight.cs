public class Knight : Charachter
{
    public Knight(string name) : base(name, 200, 18, "Knight")
    {
        addAttack();
    }
    public override void addAttack()
    {
        _attacks.Add(new Attack("Slash", 15, 5, 30));
        _attacks.Add(new Attack("Stab", 20, 5, 25));
        _attacks.Add(new Attack("Smash", 25, 5, 10));
    }
}