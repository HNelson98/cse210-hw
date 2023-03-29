public class User
{
    string _name;
    int _id;
    public static int _nextId = 0;
    List<Charachter> _characters = new List<Charachter>();

    public User(string name)
    {
        _name = name;
        _id = _nextId;
        _nextId++;
    }

    public void AddCharacter(){
       Console.WriteLine("What is the name of your character?");
       string name = Console.ReadLine();
       Console.WriteLine("What is the class of your character? (1) Knight (2) Mage (3) Ranger");
       string classType = Console.ReadLine();
       if (classType == "1")
       {
           _characters.Add(new Knight(name));
       }
       else if (classType == "2")
       {
           _characters.Add(new Mage(name));
       }
       else if (classType == "3")
       {
           _characters.Add(new Ranger(name));
       }
       else
       {
           Console.WriteLine("Invalid class type.");
       }


    }
}