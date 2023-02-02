using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       f1.SetTopNumber();
       f1.SetBottomNumber();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
       f1.SetTopNumber();
       f1.SetBottomNumber();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
       f1.SetTopNumber();
       f1.SetBottomNumber();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
       f1.SetTopNumber();
       f1.SetBottomNumber();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
    }
}