using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("black", 3);
        Rectangle rectangle1 = new Rectangle("purple", 4, 3);
        Circle circle1 = new Circle("blue", 2);

        /* Test the shape child classes.
        Console.WriteLine($"Shape color: {square1.GetColor()} | Shape area: {square1.GetArea()}");
        Console.WriteLine($"Shape color: {rectangle1.GetColor()} | Shape area: {rectangle1.GetArea()}");
        Console.WriteLine($"Shape color: {circle1.GetColor()} | Shape area: {circle1.GetArea()}");
        */

        List<Shape> shapes = new List<Shape>{square1, rectangle1, circle1};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()} | Shape area: {shape.GetArea()}");
        }
    }
}