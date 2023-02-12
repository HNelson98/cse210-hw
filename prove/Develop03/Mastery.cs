public class Mastery{
    public string scriptureMastery;
    public List<string> scripturesAsList = new List<string>();

    public int NumberOfWords;
    public Mastery(string scripture){
        scriptureMastery = scripture;
    }

    public void StringToList(){
        string[] scriptures = scriptureMastery.Split(" ");
        foreach (var item in scriptures)
        {
            scripturesAsList.Add(item);
        }
    }

    public void DisplayScripture(){
        foreach (var item in scripturesAsList)
        {
            Console.Write(item + " ");
        }
    }

    public int FindNumberOfWords(){
        List<string> noSpaceList = new List<string>();
        foreach (var item in scripturesAsList)
        {
            if (item != "______"){
                noSpaceList.Add(item);
            }
        }
        return noSpaceList.Count();
    }

    public void RemoveScripture(){
        Random random = new Random();
        IndexGenorator indexGenorator = new IndexGenorator(random.Next(0, scripturesAsList.Count), scripturesAsList.Count);
        indexGenorator.GenerateIndexes();
        foreach (var index in indexGenorator.Indexes)
        {
            scripturesAsList[index] = "______";
        }
    }
}