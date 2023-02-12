using Newtonsoft.Json.Linq;
class Scripture 
{
    public string script;
    private string _book;
    private  Dictionary<string, string> _references;

    public Scripture() 
    {
        _references = new Dictionary<string, string>();
    }

    public void InputBook(){
        Console.WriteLine("Old Testament");
        Console.WriteLine("New Testament");
        Console.WriteLine("Book of Mormon");
        Console.WriteLine("Doctrine and Covenents");
        Console.WriteLine("From which book do you want to learn? \n");
        string book = Console.ReadLine();
        AssignBook(book);
    }

    public void AssignBook(string book){
        if (book == "Old Testament"){
            _book = "OldTestament.json";
        }
        else if (book == "New Testament"){
            _book = "NewTestament.json";
        }
        else if (book == "Book of Mormon"){
            _book = "BookOfMormon.json";
        }
        else if (book == "Doctrine and Covenents"){
            _book = "DoctrineAndCovenants.json";
        }
        else{
            Console.WriteLine("That is not a valid book");
        }
    }

    public void FindReferences(){
        string path = $"./{_book}";
        string json = File.ReadAllText(path);
        JObject jObject = JObject.Parse(json);
        foreach (var item in jObject)
        {
            _references.Add(item.Key, item.Value.ToString());
        }
    }

    public void DisplayReferences(){
        foreach (var item in _references)
        {
            Console.WriteLine(item.Key);
        }
    }

    public void AssignScripture(string reference){
        script = _references[reference];
    }
}