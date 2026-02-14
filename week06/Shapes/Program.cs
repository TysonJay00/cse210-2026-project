using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Square("blue", 4));
        shapes.Add(new Rectangle("green", 5, 7));
        shapes.Add(new Circle("yellow", 6));
        
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Colour: {s.GetColour()}");
            Console.WriteLine($"Area: {s.GetArea()}");
        }
        
    }
}