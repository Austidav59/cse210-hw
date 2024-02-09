using System;
using System.Text.Json.Nodes;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {

        //instance of entry Class
        Entry entry1 = new Entry();

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
            Console.WriteLine("5. Add Prompt");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            // User Enters number to program
            Console.WriteLine("What would you like to do? ");
            string userstring = Console.ReadLine();
            int userNum = int.Parse(userstring);

            // if else statements
            if (userNum == 1)
            {
                entry1.AddEntry();
            }
            else if (userNum == 2)
            {
                entry1.DisplayAllEntries();
            }
            else if (userNum == 3)
            {
                entry1.Load();
            }
            else if (userNum == 4)
            {
                entry1.SaveEntry();
            }
            else if (userNum == 5)
            {
                entry1.AddNewPrompt();
            }
            else
            {
                number = 5;
            }

        }

    }   
}