using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Word word1 = new Word();

        string enterLoop = "enter";

        while (enterLoop != "quit")
        {

            Console.WriteLine("Enter y to continue");
            Console.WriteLine("Enter n to quit");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {

                word1.DeleteWords();

            }
            else
            {
                enterLoop = "quit";
            }
        
        }
    }
}