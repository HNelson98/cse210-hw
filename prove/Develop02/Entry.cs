public class Entry
{
    public string _title = DateTime.Now.ToString("MM/dd/yyyy");

    public Prompt entry_prompt = new Prompt();
    public string entry;

    public string produceEntry()
    {
        Console.WriteLine(_title);
        Console.WriteLine(entry_prompt.GetPrompt());
        entry = Console.ReadLine();
        return entry;
    }
}
