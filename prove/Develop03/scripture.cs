
using System.Reflection.Metadata.Ecma335;

public class Scripture
{


    private List<string> _verse1 = new List<string>();

    private List<string> _vers2 = new List<string>();

    private List<string> _verse3 = new List<string>();

    public Scripture(string verse, int num)
    {

        foreach (string word in verse.Split(" "))
        {
            if (num == 1)
            {
                _verse1.Add(word);
            }
            else if (num == 2)
            {
                _vers2.Add(word);
            }
        }
    }

    public Scripture(string verse, bool multipleVerses)
    {
        foreach (string word in verse.Split(" "))
        {
            if (multipleVerses == true)
            {
                _verse3.Add(word);
            }
        }
    }

    public void getVerse1()
    {
        foreach (string word in _verse1)
        {
            Console.WriteLine(word);
        }
    }

}