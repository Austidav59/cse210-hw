public class Reception : Event
{

    private bool _rsvp;
    private string _email;


    public Reception(string email, bool rsvp, string title, string description, string time, string address, string eventType) : base(title,description,time,address,eventType)
    {
        _rsvp = rsvp;
        _email = email;
    }

    public void DispslayFullDetails()
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
        Console.WriteLine($"Email: {_email}");

        if (_rsvp == true)
        {
            Console.WriteLine("RSVP: Required");
        }
        else
        {
            Console.WriteLine("RSVP: Not Required");
        }



    }

}