
public class Word
{
    Random rnd = new Random();

    Scripture scripture1 = new Scripture();

    Reference reference1 = new Reference();

    public void DeleteWords()
    {
        // count list length
        int scriptureListsLength = scripture1.CountVerses();

        // generate Random Number 0 to list length
        Random rnd = new Random();
        int randomNumber = rnd.Next(1,scriptureListsLength);

        //Display list at prompt index.
        Console.WriteLine();
        Console.WriteLine($"{reference1.GetReference(randomNumber)}{scripture1.GetScriptureVerses(randomNumber)}");








    }

    
}