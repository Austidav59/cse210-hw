

public class Activity
{

    protected int _startDuration;
    protected string _startMessage;
    protected string _endMessage;

    //string startMessage, string endMessage, int duration
    public Activity(string startMessage, string endMessage, int duration)
    {
        _startDuration = duration;
        _endMessage = endMessage;
        _startMessage = startMessage;

    }

    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }

    public void PauseToShowSpinner()
    {
        List<string>animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        foreach (string s in animations)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }

    public void PauseCountdown()
    {
        for (int i = 5; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }



}