using System.Text.Json;
public class User
{
    string _name;
    int _id;
    public static int _nextId;
    List<Charachter> _characters = new List<Charachter>();

    public User(string name)
    {
        _name = name;
        _id = _nextId;
        _nextId++;
        AddCharacter();
    }

   public User(){

   }

    public string getName()
    {
        return _name;
    }
    public void AddCharacter(){
       Console.WriteLine("What is the name of your character?");
       string name = Console.ReadLine();
       Console.WriteLine("What is the class of your character?");
       Console.WriteLine("1. Knight, 2. Mage, 3. Ranger");
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
           Console.WriteLine("Invalid selection.");
       }

    }
    public void dispalyCharachters()
    {
        foreach (Charachter character in _characters)
        {
            character.info();
        }
    }
    public Charachter chooseCharacter()
    {
        bool choosing = true;
        while (choosing)
        {
            int i = 0;
            if (_characters.Count == 0)
            {
                Console.WriteLine("You have no characters. Please create one.");
                AddCharacter();
                save();
                Console.Clear();
            }
            Console.WriteLine("Which character would you like to use?");
            foreach (Charachter character in _characters)
            {
                Console.WriteLine(i + ": " + character.getName());
                i++;
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice < _characters.Count)
            {
                Console.WriteLine("You have chosen " + _characters[choice].getName());
                choosing = false;
                return _characters[choice];
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
        return null;
    }

    public void save()
    {

        string folder = "users";
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        dynamic charachters = getCharachters();
        string fileName = folder + "/" + _name + ".json";
        dynamic userInfo = new Dictionary<string, dynamic>
        {
            {
                "name", _name
            },
            {
                "id", _id
            },
            {
                "characters", charachters
            }
        };
        string jsonString = JsonSerializer.Serialize(userInfo);
        File.WriteAllText(fileName, jsonString);
    }

    public dynamic getCharachters()
    {
        dynamic charichterDict = new Dictionary<string, dynamic>
        {};
        foreach (Charachter charachter in _characters)
        {
            charichterDict.Add(charachter.getName(), charachter);
        }
        return charichterDict;
    }

}