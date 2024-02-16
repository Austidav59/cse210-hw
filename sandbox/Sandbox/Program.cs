using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _parsedWordsToEdit = new List<string>();

        _parsedWordsToEdit.Add("hello");
        _parsedWordsToEdit.Add("No");
        _parsedWordsToEdit.Add("Yes");

        foreach (string Word in _parsedWordsToEdit)
        {
            if (Word == "No")
            {
                _parsedWordsToEdit[1] = "___";
                break;
            }
        }


        foreach (string word in _parsedWordsToEdit)
        {
            Console.WriteLine(word);
        }


    }
}