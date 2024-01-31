
using System.Security.Cryptography.X509Certificates;
using System.IO; 


public class Main
{


    Journal Jouranl1 = new Journal();

    DateTime date = DateTime.Now;
    
    public void AddEntry()
    {
        // Add List of prompts fr journal entry.
        Jouranl1._ListOfPrommpts.Add("Who was the most interesting person I interacted with today?");
        Jouranl1._ListOfPrommpts.Add("What was the best part of my day?");
        Jouranl1._ListOfPrommpts.Add("How did I see the hand of the Lord in my life today?");
        Jouranl1._ListOfPrommpts.Add("What was the strongest emotion I felt today?");
        Jouranl1._ListOfPrommpts.Add("If I had one thing I could do over today, what would it be?");

        // count list length
        int length = Jouranl1._ListOfPrommpts.Count();

        // generate Random Number 0 to list length
        Random rnd = new Random();
        int randomNumber = rnd.Next(1,length);

        //Display list at prompt index.
        Console.WriteLine();
        Console.WriteLine(Jouranl1._ListOfPrommpts[randomNumber]);

        //save prompt used this instance
        string prompt = Jouranl1._ListOfPrommpts[randomNumber];

        // input answer from user
        Console.WriteLine();
        Console.Write("Please Type Entry: ");
        string entry = Console.ReadLine();

        //Add entry to entry list
        Jouranl1._EntryList.Add($"Date: {date} - {prompt} - {entry} ");

    }

    public void DisplayAllEntries()
    {
        // loop through each Journal entry 
        foreach (string JournalEntry in Jouranl1._EntryList)
        {
            Console.WriteLine(JournalEntry);
            Console.WriteLine();
        }

    }

    public void SaveEntry()
    {
        // Save file name
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        
        // create new file and save
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string JournalEntry in Jouranl1._EntryList)
            {
                outputFile.WriteLine(JournalEntry);
            }

        }
    }

    public void Load()
    {
        // Choose File to open
        Console.WriteLine("What file do you want to open? ");
        string filename = Console.ReadLine();

        // use the system file reading funciton
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Loop though file and display each line
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}