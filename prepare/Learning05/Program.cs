using System;
using Shape_Objects;
class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine("Polymorphism");
        Console.WriteLine("");
        
        List<Shape> _shapes = new List<Shape>();

        SquareShape square1 = new SquareShape("Blue", 5);
        _shapes.Add(square1);

        RectangleShape rectangle1 = new RectangleShape("red", 3, 5);
        _shapes.Add(rectangle1);

        CircleShape circle1 = new CircleShape("yellow", 6);
        _shapes.Add(circle1);
        
        foreach (Shape s in _shapes)
        {
            string _color = s.Get_Color();
            double _area = s.Get_Area();

            Console.WriteLine($"The {_color} shape has an area of {_area}.");
        }
    }
}