
public class Fraction
{
    // attributes
    private int _top;

    private int _bottom;

    // Methods
    public void FractionDefault()
    {

    }

    public void FractionWholeNumber(int wholeNumber)
    {
        _bottom = wholeNumber;
    }

    public void FractionTopandBottom(int top , int bottom)
    {

    }

    // Get and Set Top
    public void GetTop()
    {

    }

    public void SetTop( int top)
    {
        top = _top;
    }

    // Get and Set Bottom
    public void GetBottom()
    {

    }

    public void SetBottom(int bottom)
    {
        bottom = _bottom;
    }

    public string GetFractionString() 
    {
        string fractionString = $"";
        return fractionString;
    }

    public double GetDecimalValue(int top , int bottom)
    {
        double decimalValue = top / bottom;
        return decimalValue;
    }
} 