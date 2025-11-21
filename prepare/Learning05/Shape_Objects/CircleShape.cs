using System.Net.NetworkInformation;

namespace Shape_Objects;
public class CircleShape : Shape
{
    private double _radius;
    public CircleShape(string color, double radius) : base (color)
    {
        _radius = radius;
    }
    public override double Get_Area()
    {
        double _area = Math.PI * Math.Pow(_radius, 2);
        return _area;
    }
}