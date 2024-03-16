using System.Runtime.CompilerServices;

public class CheckListGoal : Goal
{
    private int _points;
    private string _description;
    private int _numOfChecks;
    private string _name;

    // protected List<float> _neededToComplete = new List<float>();

    // protected List<string> _allGoals = new List<string>();
    // protected List<int> _totalPointsAdded = new List<int>();

    public CheckListGoal(int points, string description, int numOfChecks, string name)
    {
        _points = points;
        _description = description;
        _numOfChecks = numOfChecks;
        _name = name;
    }


    public override void CreateNewGoal()
    {
        _allGoals.Add(_notCheked);
        _allGoals.Add(_name);
        _allGoals.Add(_description);
        _allGoals.Add("3");
       _totalPointsAdded.Add(_points);
        _neededToComplete.Add(_numOfChecks);
    }



}