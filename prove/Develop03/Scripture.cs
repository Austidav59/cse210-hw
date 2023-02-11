using System;


class scripture
{
    private string text;
    private int wordCount;
    private string[] wordlist;



    public scripture(string newtext)
    {
        text = newtext;
        wordlist = text.Split(" ");
        wordCount = wordlist.Count();

        
    }

    public int getwordcount()
    {
        return wordCount;
    }

    public void replace(int location, string replacement)
    {
        wordlist[location] = replacement;
    }

}

