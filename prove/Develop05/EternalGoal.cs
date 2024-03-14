public class EternalGoal : Goal
{
    private int _points;
    private string _description;
    private string _name;

    public EternalGoal(int points, string description, string name)
    {
        _points = points;
        _description = description;
        _name = name;

    }


    public override void CreateNewGoal()
    {
        Console.WriteLine("Working here!");
    }


}