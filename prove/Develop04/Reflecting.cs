public class Reflecting : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    List<string> _asked = new List<string>();
    
    public Reflecting(string name, string discription) : base(name, discription)
    {
        _prompts.Add(" ---Think of a time when you felt really happy--- ");
        _prompts.Add(" ---Think of a time when you felt really sad--- ");
        _prompts.Add(" ---Think of a time when you did something really brave--- ");
        _prompts.Add(" ---Think of a time when you did something really hard--- ");
        _prompts.Add(" ---Think of a time when you felt really proud--- ");
        _prompts.Add(" ---Think of a time when you felt really angry--- ");

        _questions.Add("What was happening?");
        _questions.Add("What did you do?");
        _questions.Add("How did you feel?");
        _questions.Add("What did you learn?");
        _questions.Add("What would you do differently next time?");
        _questions.Add("What would you do the same next time?");
        _questions.Add("How did you feel after?");
        _questions.Add("What is your favourite thing about this memory?");
        _questions.Add("What is your least favourite thing about this memory?");
    }

    public int SelectPrompt()
    {
        Random rand = new Random();
        int num = rand.Next(0, _prompts.Count);
        return num;
    }

    public int SelectQuestion()
    {
        Random rand = new Random();
        int num = rand.Next(0, _questions.Count);
        return num;
    }

    public void AskQuestion()
    {
        int question = SelectQuestion();
        if (_asked.Count() == _questions.Count())
        {
            _asked.Clear();
        }
        if (_asked.Contains(_questions[question]))
        {
            AskQuestion();
        }
        else
        {
            Console.Write("\n");
            Console.Write(_questions[question] + " ");
            _asked.Add(_questions[question]);
        }
    }

    public void Reflect()
    {
        
        Greeting();
        Console.Write("How long would you like to reflect today in seconds? ");
        string string_num = Console.ReadLine();
        Console.Clear();
        time = int.Parse(string_num);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);
        GetReady();

        Console.WriteLine("Consider the following prompt:");
        int prompt = SelectPrompt();
        Console.WriteLine(_prompts[prompt]);
        Console.WriteLine("When you have something, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions as they relate to this experience.");
        FiveSecTimer();
        Console.Clear();
        while (DateTime.Now < end)
        {
            AskQuestion();
            Spinner();
        }
        Congradulations();
    }
}