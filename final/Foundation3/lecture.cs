using System.IO;
using System;
using System.Diagnostics;
public class Lecture : Event
{
    private string _speaker;
    private int _limit;

    public Lecture(string speaker, int limit, string title, string description, string time, string address, string eventType) : base(title,description,time,address,eventType)
    {
        _speaker = speaker;
        _limit = limit;

    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("Standard Detials:");
        Console.WriteLine($"Event: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Descritpion: {_description}");
        Console.WriteLine($"Date: {_date1}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine("");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_limit}");

    }
}