using System;
using System.Diagnostics;

public class Breathing : Activity
{
    Stopwatch s = new Stopwatch();

    private string _name;
    private string _description;

    public Breathing(string name, string description, string startMessage, string endMessage, int duration) : base(startMessage,endMessage,duration)
    {
        _name = name;

        _description = description;

    }

    public void DisplayBreathingMessage()
    {
        // Display start message
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();

        // description 
        Console.WriteLine(_description);
        Console.WriteLine();

        // question for duration:
        Console.WriteLine("How long in seconds, would you like for your session? ");
        string stringDuration = Console.ReadLine();
        int numDuration = int.Parse(stringDuration);

        //turn user input into thread seconds
        int miliseconds = numDuration * 1000;

        // Get ready page
        DisplayStartMessage();
        PauseToShowSpinner();
        Console.WriteLine();

        s.Start();
        while (s.Elapsed < TimeSpan.FromSeconds(numDuration)) 
        {
            Console.WriteLine("Breathe in... ");
            PauseCountdown();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Breathe out... ");
            PauseCountdown();
            Console.WriteLine();
            Console.WriteLine();
            
        }
        s.Stop();

        Console.WriteLine();
        Console.WriteLine("Well Done");
        PauseToShowSpinner();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"{_endMessage} another {numDuration} seconds of the {_name}");
        PauseToShowSpinner();

    }

}