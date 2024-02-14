
public class Scripture
{
    private List<string> _scriptureVerses = new List<string>();


    public void SetVerses(string verse)
    {
        _scriptureVerses.Add(verse);
    }

    public string GetScriptureVerses(int verseIndex)
    {
        return _scriptureVerses[verseIndex];
    }

    public int CountVerses()
    {
        return _scriptureVerses.Count();
    }
}