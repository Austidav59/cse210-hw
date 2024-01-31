using System;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        // Add List of prompts fr journal entry.
        Journal Jouranl1 = new Journal();
        Jouranl1._ListOfPrommpts.Add("Who was the most interesting person I interacted with today?");
        Jouranl1._ListOfPrommpts.Add("What was the best part of my day?");
        Jouranl1._ListOfPrommpts.Add("How did I see the hand of the Lord in my life today?");
        Jouranl1._ListOfPrommpts.Add("What was the strongest emotion I felt today?");
        Jouranl1._ListOfPrommpts.Add("If I had one thing I could do over today, what would it be?");

        //instance of Main Class
        Main Main1 = new Main();

        // While loop to keep programing running until gioven 0
        int number = -1;

        while (number != 5)
        {
            // Display Menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            // User Enters number to program
            Console.Write("Waht would you like to do?");
            string userstring = Console.ReadLine();
            int userNum = int.Parse(userstring);

            // if else statements
            if (userNum == 1)
            {
                Jouranl1.DisplayPrompts();
            }
            else if (userNum == 2)
            {
                Main1.DisplayAllEntries();
            }
            else if (userNum == 3)
            {
                Main1.Load();
            }
            else if (userNum == 4)
            {
                Main1.SaveEntry();
            }
            else
            {
                number = 5;
            }

        }

    }   
}