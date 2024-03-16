using System.IO;
public class Goal
{
    protected int _totalPoints = 0;

    protected string _notCheked = "[ ]";
    protected string _Checked = "[x]";

    protected List<float> _neededToComplete = new List<float>();

    protected List<string> _allGoals = new List<string>();
    protected List<int> _totalPointsAdded = new List<int>();


    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Console.WriteLine(parts);
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What would you like to name the file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void RecordEvent()
    {

    }

    public virtual void CreateNewGoal()
    {
         // overrride me
    }



}