using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        bool program_running = true;
        while (program_running)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Create a new user");
            Console.WriteLine("2. Select a user");
            Console.WriteLine("3. Exit");
            bool user_running = true;
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                Console.WriteLine("Enter the user name: ");
                string name = Console.ReadLine();
                User user = new User(name);
                Console.WriteLine("User created!");
                while (user_running)
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do? ");
                    Console.WriteLine("1. Add a goal");
                    Console.WriteLine("2. Show goals");
                    Console.WriteLine("3. Show info");
                    Console.WriteLine("4. Record event");
                    Console.WriteLine("5. Save and Exit");
                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        user.addGoal();
                    }
                    else if (input2 == "2")
                    {
                        user.showGoals();
                    }
                    else if (input2 == "3")
                    {
                        user.info();
                    }
                    else if (input2 == "4"){
                        Console.WriteLine("Enter the goal name: ");
                        string goalName = Console.ReadLine();
                        Goal goal = user.getGoal(goalName);
                        if (goal == null)
                        {
                            Console.WriteLine("Goal not found.");
                        }
                        else
                        {
                            user.addExperience(goal.recordEvent());
                        }
                    }
                    else if (input2 == "5")
                    {
                        user.save();
                        Console.WriteLine("User saved!");
                        Console.Clear();
                        user_running = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Enter the user name: ");
                string name = Console.ReadLine();
                User user = new User(name);
                user.load();
                while (user_running)
                {
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do? ");
                    Console.WriteLine("1. Add a goal");
                    Console.WriteLine("2. Show goals");
                    Console.WriteLine("3. Show info");
                    Console.WriteLine("4. Record event");
                    Console.WriteLine("5. Save and Exit");
                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        user.addGoal();
                    }
                    else if (input2 == "2")
                    {
                        user.showGoals();
                    }
                    else if (input2 == "3")
                    {
                        user.info();
                    }
                    else if (input2 == "4"){
                        Console.WriteLine("Enter the goal name: ");
                        string goalName = Console.ReadLine();
                        Goal goal = user.getGoal(goalName);
                        if (goal == null)
                        {
                            Console.WriteLine("Goal not found.");
                        }
                        else
                        {
                            user.addExperience(goal.recordEvent());
                        }
                    }
                    else if (input2 == "5")
                    {
                        user.save();
                        Console.WriteLine("User saved!");
                        Console.Clear();
                        user_running = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }
            else if (input == "3")
            {
                program_running = false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }


    }
}