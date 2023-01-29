public class Entry
{
    public string _title = DateTime.Now.ToString("MM/dd/yyyy");

    public Prompt entry_prompt = new Prompt();
    public string _entry;

    public Entry()
    {
    }
    public string produceEntry()
    {
        Console.WriteLine(_title);
        string prompt = entry_prompt.GetPrompt();
        Console.WriteLine(prompt);
        _entry = $"Date: {_title} {Environment.NewLine} Prompt: {prompt} {Environment.NewLine} {Console.ReadLine()}";
        return _entry;
    }

    public void displayEntry()
    {
        Console.WriteLine(_entry);
    }
}
