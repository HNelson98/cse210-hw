public class Breathing : Activity
{
    
    public Breathing(string name, string discription) : base(name, discription)
    {
    }

    public void Breathe()
    {
        Greeting();
        Console.Write("How many cycles will you complete today? ");
        string string_num = Console.ReadLine();
        Console.Clear();
        GetReady();
        int num = int.Parse(string_num);
        time = num;
        for (int i = 0; i < num; i++)
        {
            In();
            Out();
        }
        Congradulations();
    }

    public void In()
    {
        Console.Write("\nInhale...6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
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


        Console.Write("\nHold...4");
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
    public void Out()
    {
        Console.Write("\n\nExhale...10");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("9");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
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
}