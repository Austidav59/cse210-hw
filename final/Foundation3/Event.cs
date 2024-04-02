using System.ComponentModel;

public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date1 = DateTime.Today;    
    protected string _time;
    protected string _address;

    public Event(string title, string description, string time, string address, string eventType)
    {
        _eventTitle = title;

        _description = description;

        _time = time;

        _address = address;

        _eventType = eventType;
    }

    public void ShortDescrition()
    {
        Console.WriteLine("");
        Console.WriteLine("Short Detials:");
        Console.WriteLine($"Event: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date1}");

    }

    public void StandardDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("Standard Detials:");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Descritpion: {_description}");
        Console.WriteLine($"Date: {_date1}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");

    }
}