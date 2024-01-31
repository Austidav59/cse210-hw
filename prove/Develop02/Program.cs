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
            Console.Write("5. Quit");

            // User Enters number to program
            Console.WriteLine("Waht would you like to do?");
            string userstring = Console.ReadLine();
            int userNum = int.Parse(userstring);

            // if else statements
            if (userNum == 1)
            {

            }
            else if (userNum == 2)
            {

            }
            else if (userNum == 3)
            {

            }
            else if (userNum == 4)
            {

            }
            else
            {
                number = 5;
            }

            






        }







    }   
}