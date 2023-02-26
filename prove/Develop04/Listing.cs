public class Listing : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _responses = new List<string>();
    public Listing(string name, string discription) : base(name, discription)
    {
        _prompts.Add(" ---When you felt joy this month?--- ");
        _prompts.Add(" ---When Have you felt the Holy Ghost this month?--- ");
        _prompts.Add(" ---When you felt peace this month?--- ");
        _prompts.Add(" ---When you felt love this month?--- ");
        _prompts.Add(" ---When you felt gratitude this month?--- ");
    }

    public int SelectPrompt()
    {
        Random rand = new Random();
        int num = rand.Next(0, _prompts.Count);
        return num;
    }

    public void List()
    {
        Greeting();
        Console.Write("How long would you like to List today in seconds? ");
        string string_num = Console.ReadLine();
        Console.Clear();
        time = int.Parse(string_num);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);
        GetReady();

        Console.WriteLine("\nList as many responses as you can to the following prompt");
        int prompt = SelectPrompt();
        Console.WriteLine(_prompts[prompt]);
        FiveSecTimer();
        Console.WriteLine("\n");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine($"You listed {_responses.Count} responses!");
        Congradulations();

    }
}