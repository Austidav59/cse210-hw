public class Swimming : Activity
{
    private float _distanceMiles;

    public Swimming(float distanceMiles, string date, string lengthminiutes) : base(date,lengthminiutes)
    {
        _distanceMiles = distanceMiles;
    }

    public void GetPace()
    {

    }

    public override void GetSummary()
    {
        
    }

}