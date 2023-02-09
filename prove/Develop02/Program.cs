using System;
using System.IO;



class Program   
{

static void Main(string[] args)
{
    // create the list
    List<string> prompts = new List<string>();
    prompts.Add("What Was your favorite part of today? ");
    prompts.Add("What was the most challenging part of today? ");
    prompts.Add("Why was today a good day? ");
    prompts.Add("Why are you grateful today? ");

    List<string> filesCreated = new List<string>();
    
    // start the while loop
    bool input = true;
    while (input == true)
    {

        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("");

        String read = Console.ReadLine();
        int number = int.Parse(read);

        if (number == 1)
        {
            // randomly pick a prompt
            Random R = new Random();
            int someRandomNumber = R.Next(0, prompts.Count());
            Console.WriteLine(prompts.ElementAt(someRandomNumber));
            string JournaEntry = Console.ReadLine();

            //make a random file name
            string randomString = Path.GetRandomFileName();
            

            // write to a file!
            string newJournal = randomString;
            using (StreamWriter outputFile = new StreamWriter(newJournal,true))
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(JournaEntry);
            filesCreated.Add(newJournal);
            Console.WriteLine(newJournal);

        }
        else if (number == 2)
        {
            
            var lines = File.ReadLines(filesCreated[0]);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
                Console.WriteLine("");
            }


        }
        else if (number == 3)
        {
            Console.Write("What file would you like to open? ");
            var path = Console.ReadLine();
            var lines = File.ReadLines(path);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
                Console.WriteLine("");
            }

            
        }
        else if (number == 4)
        {
            Console.Write("What is the name of the file you would like to change? ");
            string oldfilename = Console.ReadLine();
            Console.Write("What is the new filename? ");
            string newfilename = Console.ReadLine();
            System.IO.File.Move(oldfilename, newfilename);

        }
        else
        {
            Console.Write("Quit");
            input = false;
        }
    }
}

}

