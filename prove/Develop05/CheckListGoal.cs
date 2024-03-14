using System.Runtime.CompilerServices;

public class CheckListGoal : Goal
{
    private int _points;
    private string _description;
    private int _numOfChecks;
    private string _name;

    public CheckListGoal(int points, string description, int numOfChecks, string name)
    {
        _points = points;
        _description = description;
        _numOfChecks = numOfChecks;
        _name = name;
    }

    public override void CreateNewGoal()
    {
        Console.WriteLine("Working here!");
    }



}