public class Fraction {

    private int _topNum;
    private int _bottomNum;

    public Fraction(){
        _topNum = 1;
        _bottomNum = 1;

    }

    public Fraction(int denom){
        _topNum = denom;
        _bottomNum = 1;
        Console.WriteLine($"{_topNum}/{_bottomNum}");
    }
    public Fraction(int denom, int numer){
        _topNum = denom;
        _bottomNum = numer;
        Console.WriteLine($"{_topNum}/{_bottomNum}");
    }

    public void SetTopNumber(){
        Console.Write("Set the top number: ");
        string string_num = Console.ReadLine();
        int num = int.Parse(string_num);
        _topNum = num;
    }
      public void SetBottomNumber(){
        Console.Write("Set the bottom number: ");
        string string_num = Console.ReadLine();
        int num = int.Parse(string_num);
        _bottomNum = num;
    }
    public string GetFractionString(){
        string fraction = $"{_topNum}/{_bottomNum}";
        return fraction;
    }
    public double GetDecimalValue(){
        double dec = (double)_topNum/_bottomNum;
        return dec;
    }
}