public class IndexGenorator {
    public List<int> Indexes = new List<int>();
    private int _NumberOfIndexes;

    private int _maxIndex;

    public IndexGenorator(int numberOfIndexes, int maxIndex){
        _NumberOfIndexes = numberOfIndexes;
        _maxIndex = maxIndex;
    }

    public void GenerateIndexes(){
        Random random = new Random();
        for (int i = 0; i < _NumberOfIndexes; i++)
        {
            int index = random.Next(0, _maxIndex);
            Indexes.Add(index);
        }
    }
}