namespace Shape_Objects;
public class RectangleShape : Shape
{
    private double _length;
    private double _width;
    public RectangleShape(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }
    public override double Get_Area()
    {
        double _area = _length * _width;
        return _area;
    }
}