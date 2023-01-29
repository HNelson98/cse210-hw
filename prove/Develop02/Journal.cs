public class Journal
{
    public List<string> _entries = new List<string>();

    public Journal()
    {
    }
    public void displayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry + Environment.NewLine);
        }
    }
}

