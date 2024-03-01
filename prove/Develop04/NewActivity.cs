public class NewActivity
{

    private List<string>_activitySugestions = new List<string>();

    public void SuggestActivity()
    {
        Console.WriteLine("Suggest an activity: ");
        string newActivity = Console.ReadLine();

        _activitySugestions.Add(newActivity);

        Console.WriteLine("Thank you for your suggestion we will take it into careful consideration.");
    }


}