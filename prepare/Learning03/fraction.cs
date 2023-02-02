using System;

public class Fraction
{

private int _top;
private int _bottom;

public Fraction()
{
    _top=1;
    _bottom=1;
}

public Fraction(int compNumb)
{
    _top=compNumb;
    _bottom=1;
}

public Fraction(int numerator, int denominator)
{
    _top=numerator;
    _bottom=denominator;

}
public string GetFractionString()
{
    string display=$"{_top}/{_bottom}";
    return display;
}
public double GetDecimalValue()
{
return(double)_top/(double)_bottom;
}
}