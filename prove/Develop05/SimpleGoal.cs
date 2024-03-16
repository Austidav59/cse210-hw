using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private int _points;
    private string _description;
    private string _name;

    // protected List<float> _neededToComplete = new List<float>();

    // protected List<int> _totalPointsAdded = new List<int>();
    List<string> _allGoals1 = new List<string>();


    public SimpleGoal(int points, string description, string name)
    {
        _points = points;
        _description = description;
        _name = name;

    }

    public SimpleGoal()
    {

    }

    public override void CreateNewGoal()
    {

        _allGoals1.Add(_notCheked);
        _allGoals1.Add(_name);
        _allGoals1.Add(_description);
        _totalPointsAdded.Add(_points);


        foreach ( string i in _allGoals1)
        {
            Console.Write($"{i}");
            Console.Write(" ");
        }

    }

    public void ListGoals()
    {
        foreach ( string i in _allGoals1)
        {
            Console.Write($"{i}");
        }

    }

}