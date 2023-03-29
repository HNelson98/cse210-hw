public class User
{
    string _name;
    List<Goal> _goals = new List<Goal>();
    string _level = "Shiny";
    int _experience = 0;
    public User(string name)
    {
        _name = name;
    }

    public void addGoal()
    {
        Console.WriteLine("Enter the goal name: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("Enter the goal description: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What type of goal is this? (1) Simple (2) Eternal (3) Checklist");
        string goalType = Console.ReadLine();

        if (goalType == "3")
        {
            Console.WriteLine("How many times do you want to complete this goal? ");
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many points do you want to earn for each time you complete this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many bonus points do you want to earn for completing this goal? ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            _goals.Add(new Checklist("checklist", goalName, goalDescription, points, bonus, times, 0, false));
        }
        else if (goalType == "2")
        {
            Console.WriteLine("How many points do you want to earn for completing this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            _goals.Add(new Eternal("eternal", goalName, goalDescription, points, false));
        }
        else if (goalType == "1")
        {
            Console.WriteLine("How many points do you want to earn for completing this goal? ");
            int points = Convert.ToInt32(Console.ReadLine());
            _goals.Add(new Simple("simple", goalName, goalDescription, points, false));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void showGoals()
    {
        foreach (Goal goal in _goals)
        {
            if( goal.checkIfCompleted() == true)
            {
                Console.Write("[X] ");
                goal.info();
            }
            else
            {
                Console.Write("[ ] ");
                goal.info();
            }
        }
    }

    public void info()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Level: " + _level);
        Console.WriteLine("Experience: " + _experience);
    }

    public void LevelUp()
    {
        if (_experience >= 9000)
        {
            _level = "MASTER OF THE UNIVERSE";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
            Console.WriteLine("You have reached the highest level possible!");
            Console.ReadLine();
        }
        else if (_experience >= 8000)
        {
            _level = "Legendary";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 7000)
        {
            _level = "Jedi Master";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 6000)
        {
            _level = "Master";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 5000)
        {
            _level = "Expert";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 4000)
        {
            _level = "Advanced";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 3000)
        {
            _level = "Intermediate";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 2000)
        {
            _level = "Beginner";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
        else if (_experience >= 1000)
        {
            _level = "Noob";
            Console.WriteLine("You have leveled up! your level is now " + _level + "!");
        }
    }

    public void addExperience(int experience)
    {
        _experience += experience;
        LevelUp();
    }

    public Goal getGoal(string name)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.getName() == name)
            {
                return goal;
            }
        }
        return null;
    }

    public void save()
    {
        File.Create(@"C:\Users\Henry\Documents\BYUI Winter Semester 2\CSE-210 Programming with Classes\cse210-hw\prove\Develop05\" + _name + ".txt").Close();   
        string path = @"C:\Users\Henry\Documents\BYUI Winter Semester 2\CSE-210 Programming with Classes\cse210-hw\prove\Develop05\" + _name + ".txt";
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine(_name);
            sw.WriteLine(_level);
            sw.WriteLine(_experience);
            foreach (Goal goal in _goals)
            {
                if (goal.version() == "simple")
                {
                    sw.WriteLine(goal.version() + ";" + goal.getName() + ";" + goal.getDescription() + ";" + goal.getPoints() + ";" + goal.checkIfCompleted());
                }
                else if (goal.version() == "eternal")
                {
                    sw.WriteLine(goal.version() + ";" + goal.getName() + ";" + goal.getDescription() + ";" + goal.getPoints() + ";" + goal.checkIfCompleted());
                }
                else if (goal.version() == "checklist")
                {
                    sw.WriteLine(goal.version() + ";" + goal.getName() + ";" + goal.getDescription() + ";" + goal.getPoints() + ";" + ((Checklist)goal).getBonus() + ";" + ((Checklist)goal).getTimesToComplete() + ";" + ((Checklist)goal).getTimesCompleted() + ";" + goal.checkIfCompleted());
                }
            }
        }
    }

    public void load()
    {
        string path = @"C:\Users\Henry\Documents\BYUI Winter Semester 2\CSE-210 Programming with Classes\cse210-hw\prove\Develop05\" + _name + ".txt";
        using (StreamReader sr = File.OpenText(path))
        {
            _name = sr.ReadLine();
            _level = sr.ReadLine();
            _experience = Convert.ToInt32(sr.ReadLine());
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] data = s.Split(';');
                if (data[0] == "simple")
                {
                    _goals.Add(new Simple(data[0], data[1], data[2], Convert.ToInt32(data[3]), Convert.ToBoolean(data[4])));
                }
                else if (data[0] == "eternal")
                {
                    _goals.Add(new Eternal(data[0], data[1], data[2], Convert.ToInt32(data[3]), Convert.ToBoolean(data[4])));
                }
                else if (data[0] == "checklist")
                {
                    _goals.Add(new Checklist(data[0], data[1], data[2], Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]), Convert.ToBoolean(data[7])));
                }
            }
        }
    }
    


}