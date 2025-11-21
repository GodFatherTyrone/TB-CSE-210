namespace Shape_Objects;
public class SquareShape : Shape
{
    private double _side;
    public SquareShape(string color, double side) : base (color)
    {
        _side = side;
    }
    public override double Get_Area()
    {
        double _area = _side * _side;
        return _area;
    }
}