namespace Shape_Objects;
public abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string Get_Color()
    {
        return _color;
    }
    public abstract double Get_Area();
}