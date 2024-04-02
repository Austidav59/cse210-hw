public class Running : Activity
{
    private float _distance;

    public class Running(float distance, string date, string lengthminiutes) : base(date,lengthminiutes)
    {
        _distance = distance;
    }

    public float GetDistance()
    {
        
    }

    public override void GetSummary()
    {

    }

}