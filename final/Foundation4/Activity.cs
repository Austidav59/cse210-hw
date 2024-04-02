public abstract class Activity
{

    protected string _date;
    protected int _lengthMiniutes;

    public Activity(string date, int lengthminiutes)
    {
        _date = date;
        _lengthMiniutes = lengthminiutes;

    }

    public abstract void GetSummary();

}