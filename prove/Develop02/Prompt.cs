public class Prompt
{
    static Random rnd = new Random();
    private List<string> _prompts = new List<string>{
        "Every single day I’m grateful for ", 
        "What are the values that you most cherish in a friend? Now write down the names of the friends you’re lucky to have because they have these qualities. ",
        "My favorite smell is… Write about a happy memory associated with five different scents that make you happy. ",
        "Five of my happiest memories are… ", "Write a paragraph about why you love each season of the year. ", 
        "Do you have any calming rituals? Write about it and why you find comforting. If you don’t, create one now ",
        "Write about the highlight of your day."
    };

    public string GetPrompt()
    {
        int rand = rnd.Next(_prompts.Count());
        return _prompts[rand];
    }
}