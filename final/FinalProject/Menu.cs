using System.Text.Json;

public class Menu
{
    string _selection;
    User player1;
    User player2;
    Charachter char1;
    Charachter char2;

    public Menu()
    {
        while (_selection != "5")
        {
            runMenu();
        }
    }

    public void runMenu()
    {
        if (player1 != null)
        {
            Console.WriteLine($"Player 1: {player1.getName()}");
        }
        else
        {
            Console.WriteLine("Player 1: None");
        }
        if (player2 != null)
        {
            Console.WriteLine($"Player 2: {player2.getName()}");
        }
        else
        {
            Console.WriteLine("Player 2: None");
        }
        Console.WriteLine("1. Start Combat");
        Console.WriteLine("2. Choose Players");
        Console.WriteLine("3. Create User");
        Console.WriteLine("4. Create Character");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Please select an option: ");
        _selection = Console.ReadLine();
        if (_selection == "1")
        {
            bool choosing = true;
            while (choosing)
            {
                if (player1 == null)
                {
                    Console.WriteLine("Player 1, please choose a user.");
                    choosePlayer();
                }
                else if (player2 == null)
                {
                    Console.WriteLine("Player 2, please choose a user.");
                    choosePlayer();
                }
                else if (char1 == null)
                {
                    Console.WriteLine("Player 1, please choose a character.");
                    char1 = player1.chooseCharacter();
                }
                else if (char2 == null)
                {
                    Console.WriteLine("Player 2, please choose a character.");
                    char2 = player2.chooseCharacter();
                }
                else
                {
                    choosing = false;
                }
            }
            Console.WriteLine("Starting Combat");
            Combat combat = new Combat();
            while (!combat.haveWinner())
            {
                combat.displayCombat();
                combat.playerTurn(char1, char2);
                combat.checkWinner(char1, char2);
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            
            
        }
        else if (_selection == "2")
        {
            choosePlayer();
        }
        else if (_selection == "3")
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            User user = new User(name);
            user.save();
            Console.WriteLine("User created.");
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        else if (_selection == "4")
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string path = $"users\\{name}.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                User user = JsonSerializer.Deserialize<User>(json, new JsonSerializerOptions { WriteIndented = true });
                user.AddCharacter();
                user.save();
            }
            else
            {
                Console.WriteLine("User not found.");
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }
        else if (_selection == "5")
        {
            Console.Write("Exiting in: 3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("0");
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

    }
    
    public void choosePlayer()
    {
        Console.WriteLine("Player 1 or Player 2? (1 or 2)");
        string player = Console.ReadLine();
        if (player == "1")
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string path = $"users\\{name}.json";
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                player1 = JsonSerializer.Deserialize<User>(jsonString, new JsonSerializerOptions { WriteIndented = true });           
            }
            else
            {
                Console.WriteLine("User not found.");
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            Console.WriteLine("Player 1: " + name);
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        else if (player == "2")
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string path = $"users\\{name}.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                player2 = JsonSerializer.Deserialize<User>(json, new JsonSerializerOptions { WriteIndented = true });
            }
            else
            {
                Console.WriteLine("User not found.");
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            Console.WriteLine("Player 2: " + name);
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

        }
        else
        {
            Console.WriteLine("Invalid player number.");
        }
        
    }


}