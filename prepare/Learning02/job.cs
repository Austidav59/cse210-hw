public class Job {

    public string _jobTitle = "Software Engineer";
    public string _company = "Amazon";
    public int _startYear = 2020;
    public int _endYear = 2023;

    public void DisplayMessage()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}