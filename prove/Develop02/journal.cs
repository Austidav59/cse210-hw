using System.IO; 

public class Journal
{
    public List<string> _ListOfPrommpts = new List<string>();

    public List<string> _EntryList = new List<string>();


    public void AddListPrompts(string prompts)
    {
        _ListOfPrommpts.Add(prompts);
       
    }

}
