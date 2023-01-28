using System;

public class job
    {
        // The C# convention is to start member variables with an underscore _
        public string _Name = "";
        public string _job = "";
    internal string _jobTitle;
    internal string _jobCompany;
    internal string _jobYearsexperience;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public job()
        {
        }
    }

public class resume
    {
    internal readonly object _job1;

    // The C# convention is to start member variables with an underscore _

    internal string _name = "";
    internal string _jobs = "";
    internal string resume1;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public resume()
        {
        }

    public static string resume2 { get; internal set; }

    internal static void Display()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {

        job job1 = new job();
        job1._Name = "Austin Davis";
        job1._job = "Sales Reperesentative";
        job1._jobTitle = "manager";
        job1._jobCompany = "Vivint";
        job1._jobYearsexperience = "3";

        job job2 = new job();
        job2._Name = "Marisabel Trejo";
        job2._job = "Cashier";
        job2._jobTitle = "manager";
        job2._jobCompany = "ADT";
        job2._jobYearsexperience = "4";


        resume resume1 = new resume();
        resume1._name = "Allison Rose";



        resume.Display();
    }
}