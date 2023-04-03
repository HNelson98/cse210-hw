public class Combat
{
    int _turn = 0;
    string _playerTurn;
    int distance;
    bool _haveWinner = false;

    public Combat()
    {
        distance = 100;
        int num = new Random().Next(1,2);
        if (num == 1)
        {
            _playerTurn = "player1";
        }
        else
        {
            _playerTurn = "player2";
        }
    }

    public bool haveWinner()
    {
        return _haveWinner;
    }

    public void displayCombat()
    {
        Console.WriteLine($"Distance: {distance}");
        Console.WriteLine($"Turn: {_turn}");
        Console.WriteLine($"{_playerTurn}'s turn");
    }

    public void playerTurn(Charachter player1, Charachter player2)
    {
        if (_playerTurn == "player1")
        {
            Console.WriteLine("Player 1, please choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player1.attack(distance, player2);

            }
            else if (choice == "2")
            {
                run();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        else
        {
            Console.WriteLine("Player 2, please choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player2.attack(distance, player1);
            }
            else if (choice == "2")
            {
                run();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        _turn++;
        if (_playerTurn == "player1")
        {
            _playerTurn = "player2";
        }
        else
        {
            _playerTurn = "player1";
        }
        }

    public void run()
    {
        Console.WriteLine("Towards or Away?");
                string direction = Console.ReadLine();
                if (direction == "Towards")
                {
                    int feet = new Random().Next(1, 30);
                    if (distance < 5 && feet > distance && distance - feet < 5) 
                    {
                        Console.WriteLine("You cannot run any closer!");
                    }
                    else
                    {
                        distance = distance - feet;
                        Console.WriteLine($"You ran {feet} feet towards your opponent.");
                        Console.WriteLine($"You are now {distance} feet away.");
                    }
                }
                else if (direction == "Away")
                {
                    int feet = new Random().Next(1, 30);
                    distance = distance + feet;
                    Console.WriteLine($"You ran {feet} feet away from your opponent.");
                    Console.WriteLine($"You are now {distance} feet away.");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
    }

    public void checkWinner(Charachter player1, Charachter player2)
    {
        if (player1.getHealth() <= 0)
        {
            Console.WriteLine("Player 2 Wins!");
            _haveWinner = true;
        }
        else if (player2.getHealth() <= 0)
        {
            Console.WriteLine("Player 1 Wins!");
            _haveWinner = true;
        }
        Console.WriteLine("press enter to continue...");
        Console.ReadLine();
    }
}