public abstract class Activity
{

    protected string _date;
    protected string _lengthMiniutes;

    public Activity(string date, string lengthminiutes)
    {
        _date = date;
        _lengthMiniutes = lengthminiutes;

    }

    public abstract void GetSummary();

}