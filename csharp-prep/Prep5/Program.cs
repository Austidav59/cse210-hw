using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your age: ");
            string userNum = Console.ReadLine();
            int userNumber = int.Parse(userNum);
            return userNumber;
        }

        static int SquaredNumber( int age)
        {
            int num = age * age;
            return num;
        }

        static void DisplayResult(string name, int numSquared)
        {
            Console.WriteLine($"{name}, The square of your number is {numSquared}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int age = PromptUserNumber();
        int numSquared = SquaredNumber(age);
        DisplayResult(name, numSquared);

    }
}