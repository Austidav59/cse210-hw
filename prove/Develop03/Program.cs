using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
         Word word1 = new Word();


        string enterLoop = "enter";

        while (enterLoop != "quit")
        {
            Console.WriteLine("press 1 to continue");
            Console.WriteLine("Type quit to end");
            Console.WriteLine("Press 2 to add a scripture ");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

                word1.DeleteWords();

            }
            else if (userInput == "2")
            {
                Console.WriteLine("please paste reference: ");
                string reference = Console.ReadLine();

                Console.WriteLine("Paset Verse Here: ");
                string verse = Console.ReadLine();
                
                Scripture scritpure1 = new Scripture(verse, reference);
            }
            else
            {
                enterLoop = "quit";
            }
        
        }
    }
}