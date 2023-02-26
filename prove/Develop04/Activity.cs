public class Activity
{
    string _name;
    string _discription;
    protected int time;
    



    public Activity(string name, string discription)
    {
        _name = name;
        _discription = discription;
    }
    public void Greeting()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to {_name} Activity. \nThis activity will help you relax by {_discription}");
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        Spinner();
    }

    public void Congradulations()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed another round of {_name}");
        Spinner();
        Console.Clear();
    }

    public void FiveSecTimer()
    {
        Console.Write("You may begin in: 5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("0");
    }

    public void Spinner()
    {
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|"); 
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/"); 
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|"); 
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/"); 
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|");
    }
}
