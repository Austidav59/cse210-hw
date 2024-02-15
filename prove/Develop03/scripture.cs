
public class Scripture
{
    private List<string> _scriptureVerses = new List<string>();

    private List<string> _editedVerse = new List<string>();

    private List<string> _parsedVerse = new List<string>();

    private List<int> _indexReplaced = new List<int>();



    private int count = 0;


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

    public void SetEditedVerse(string verse)
    {
        _editedVerse.Add(verse);
    }

    public string GetEditedVerses()
    {
        return _editedVerse[0];
    }

    public void AddCount()
    {
        count = count + 1;
    }

    public int GetCount()
    {
        return count;
    }

    public void SetParsedVerse(string word)
    {
        _parsedVerse.Add(word);
    }

    public void GetParsedVerses()
    {
        foreach (string str in _parsedVerse)
        {
            Console.WriteLine(str);
        }
    }

    public int CountParsedList()
    {
        return _parsedVerse.Count();
    }

    public void SetIndexReplaced(int num1)
    {
        _indexReplaced.Add(num1);
    }

    public bool CheckIndexUse(int num)
    {
        foreach (int number in _indexReplaced)
        {
            if (number == num)
            {
                
                return false;
            }

        }

        return false;
    }



}