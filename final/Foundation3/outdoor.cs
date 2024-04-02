public class Outdoor : Event
{
    private string _eventWeather;


    public Outdoor(string eventWeather, string title, string description, string time, string address, string eventType) : base(title,description,time,address,eventType)
    {
        _eventWeather = eventWeather;
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
        Console.WriteLine($"Weather Statement: {_eventWeather}");
    }
}