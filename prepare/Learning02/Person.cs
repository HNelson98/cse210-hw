public class Person
{
    private string _givenName = "";
    private string _familyName = "";

    public Person()
    {
    }

    public void SetGivenName()
    {
        _givenName = Console.ReadLine();
    }

    public void SetFamilyName()
    {
        _familyName = Console.ReadLine();
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName} {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName}, {_familyName}");
    }
}