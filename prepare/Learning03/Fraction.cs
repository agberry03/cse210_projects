public class Fraction
{
    private int _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    
    public double GetDecimalValue()
    {
        return Math.Round((double)_numerator / (double)_denominator, 2);
    }
}