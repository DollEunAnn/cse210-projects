using System;

class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base (color)
    {
        _side = side;

    }

    public override double GetArea()
    {
        double area = _side * 2;
        return area;

    }
}