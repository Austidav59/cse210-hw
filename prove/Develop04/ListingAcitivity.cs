using System;
using System.Diagnostics;
public class Listing : Activity
{
    Stopwatch s = new Stopwatch();
    Random rnd = new Random();
    protected int _duration;
    protected string _name;
    protected string _descritpion;

    List<string>listPrompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string name, string description, int duration, string endMessage, string startMessage ) : base(endMessage,startMessage,duration)
    {
        _name = name;

        _descritpion = description;

    }

    public string GetRandomPrompt()
    {
        // count list
        int promptCounted = listPrompts.Count();

        // Random number from list
        int randPromptNum = rnd.Next(0,promptCounted);

        string randPrompt = listPrompts[randPromptNum];
        return randPrompt;

    }

    public void DisplayListingPrompts()
    {
        // start message
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();

        // Desecription
        Console.WriteLine(_descritpion);
        Console.WriteLine();

        // Ask question in seconds of how long
        Console.WriteLine("How long in seconds, would you like for your session? ");
        string stringDuration = Console.ReadLine();
        int numDuration = int.Parse(stringDuration);

        int miliseconds = numDuration * 1000;

        // Get ready and spinner
        DisplayStartMessage();
        PauseToShowSpinner();
        Console.WriteLine();

        Console.WriteLine($"List as many repsonses you can in the next {numDuration} seconds to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin in:");
        PauseCountdown();

        int count = 0;
        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(numDuration)) 
        {
            Console.WriteLine("> type: ");
            string answer = Console.ReadLine();
            count = count + 1;

        }
        s.Stop();
        Console.WriteLine($"You ahve listed {count} items");
        Console.WriteLine();

        Console.WriteLine("Well Done!!");
        Console.WriteLine();

        Console.WriteLine($"{_endMessage} another {numDuration} seconds of the {_name}");
        PauseToShowSpinner();



















    }


}