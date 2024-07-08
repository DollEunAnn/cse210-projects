using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();

        Square square = new Square(10, "red");
        shapes.Add(square);
        // Console.WriteLine($"{square.GetArea()}");
        // Console.WriteLine($"{square.GetColor()}");


        Circle circle = new Circle(10, "green");
        shapes.Add(circle);
        // Console.WriteLine($"{circle.GetArea()}");
        // Console.WriteLine($"{circle.GetColor()}");

        Rectangle rectangle= new Rectangle(13,13, "yellow");
        shapes.Add(rectangle);
        // Console.WriteLine($"{rectangle.GetArea()}");
        // Console.WriteLine($"{rectangle.GetColor()}");

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetArea()}");
            Console.WriteLine($"{shape.GetColor()}");
        }






    }
}