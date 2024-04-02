public class Running : Activity
{

    private float _distance;

    public Running(float distance,string date, int lengthminiutes) : base(date, lengthminiutes)
    {
        _distance = distance;
    }

    public float GetSpeed()
    {
        float Speed = (_distance / _lengthMiniutes) * 60;
        return Speed;
    }

    public float GetPace()
    {
        float pace = _lengthMiniutes / _distance;
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date} Running ({_lengthMiniutes} Min) - Distance {_distance} miles, Speed {GetSpeed().ToString("0.00")} MPH, Pace {GetPace().ToString("0.00")} per mile");
        Console.WriteLine("");
    }






}