public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() //constructor
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int numerator) //constructors t
    {
        _top = numerator;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator) //constructors t,b
    {
        _top = numerator;
        _bottom = denominator;
    }


    public int GetNumerator() //get top
    {
        return _top;
    }
    public void SetNumerator(int numerator) //set top
    {
        _top = numerator;
    }
    public int GetDenominator() //get bottom
    {
        return _bottom;
    }
    public void SetDenominator(int denominator) //set bottom
    {
        _bottom = denominator;
    }


    public string GetFractionString()
    {
        string _fraction= _top + "/" + _bottom;
        return _fraction;
    }
    public double GetDecimalValue()
    {
        double _decimal = (double)_top / (double)_bottom;
        return _decimal;
    }
}