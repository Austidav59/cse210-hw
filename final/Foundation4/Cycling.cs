public class Cycling : Activity
{
    private float _distance;

    public Cycling(float distance, string date, int lengthminiutes) : base(date,lengthminiutes)
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
        Console.WriteLine($"{_date} Cycling ({_lengthMiniutes} Min) - Distance {_distance} miles, Speed {GetSpeed().ToString("0.00")}, Pace {GetPace().ToString("0.00")} Min per mile");
        Console.WriteLine("");
    }




}