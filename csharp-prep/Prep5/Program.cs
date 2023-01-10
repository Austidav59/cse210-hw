using System;

class Program
{
    static void Main(string[] args)
    {

        string username = PromptUserName();
        int usernumber = PromptUserNumber();

        int squarednum = SquareNumber(usernumber);

        DisplayResult(squarednum, username);


    }
    static string PromptUserName()
    {
        Console.WriteLine($"What is your username? ");
        string username = Console.ReadLine();

        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("what is you you faviorite whole number?  ");
        string number = Console.ReadLine();
        int num = int.Parse(number);

        return num;
    }
    static int SquareNumber(int num)
    {
        var squared = num^2;
        return squared;
    }
    static void DisplayResult(int squared, string username)
    {
        Console.WriteLine($"Your username is {username}");
        Console.WriteLine($"Yhe square of your number is {squared}");
    }

    
}   