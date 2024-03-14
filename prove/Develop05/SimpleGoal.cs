public class SimpleGoal : Goal
{
    private int _points;
    private string _description;
    private string _name;

    public SimpleGoal(int points, string description, string name)
    {
        _points = points;
        _description = description;
        _name = name;

    }


    public override void CreateNewGoal()
    {
        Console.WriteLine(_points);
        Console.WriteLine(_description);
        Console.WriteLine(_name);


    }

}