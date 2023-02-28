using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("red", 2));
        shapes.Add(new Rectangle("blue", 2, 3));
        shapes.Add(new Square("green", 2));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor() + " " + shape.GetArea());
        }
    }
}