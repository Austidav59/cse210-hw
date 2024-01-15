using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        static void DisplayMessage()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int age = PromptUserNumber();
            int squareNum = squareNumber(age);


        }

        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            PromptUserNumber();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your age: ");
            string userNum = Console.ReadLine();
            int userNumber = int.Parse(userNum);
            return userNumber;
        }

        static int squareNumber(int age)
        {
            int squared = age * age;
            return squared;
        }

    }
}