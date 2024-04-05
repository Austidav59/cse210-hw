public class Swimming : Activity
{
    private float _laps;
    public Swimming(int laps, string date, int lengthminiutes) : base(date,lengthminiutes)
    {
        _laps = laps;
    }
    public float GetSpeed()
    {
        float Speed = (GetDistance() / _lengthMiniutes);
        return Speed;
    }

    public float GetPace()
    {
        float pace = _lengthMiniutes / GetDistance();
        return pace;
    }

    public float GetDistance()
    {
        float distance = _laps / 16.1f;
        return distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date} Swimming ({_lengthMiniutes} Min) - Distance {GetDistance().ToString("0.00")} miles, Speed {GetSpeed().ToString("0.00")}, Pace {GetPace().ToString("0.00")} Min per mile");
        Console.WriteLine("");
    }

}