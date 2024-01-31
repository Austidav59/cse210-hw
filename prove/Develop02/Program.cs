using System;
using System.Text.Json.Nodes;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {

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
            Console.WriteLine("What would you like to do? ");
            string userstring = Console.ReadLine();
            int userNum = int.Parse(userstring);

            // if else statements
            if (userNum == 1)
            {
                Main1.AddEntry();
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