public class EternalGoal : Goal
{
    private int _points;
    private string _description;
    private string _name;

    // protected List<float> _neededToComplete = new List<float>();

    // protected List<string> _allGoals = new List<string>();
    // protected List<int> _totalPointsAdded = new List<int>();


    public EternalGoal(int points, string description, string name)
    {
        _points = points;
        _description = description;
        _name = name;

    }



    public override void CreateNewGoal()
    {
        _allGoals.Add(_notCheked);
        _allGoals.Add(_name);
        _allGoals.Add(_description);
        _allGoals.Add("2");
        _totalPointsAdded.Add(_points);

        foreach ( string i in _allGoals)
        {
            Console.Write($"{i}");
            Console.Write(" ");
        }
    }


}