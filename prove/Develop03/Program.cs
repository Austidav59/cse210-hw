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

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
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