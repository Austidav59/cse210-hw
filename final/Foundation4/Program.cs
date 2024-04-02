using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swimming1 = new Swimming(9,"03 Nov 2023",178);
        Running running1 = new Running(1.9f,"04 Nov 2024",66);
        Cycling cycling1 = new Cycling(45.3f,"05 Nov 2024", 300);

        //Display Details
        swimming1.GetSummary();
        running1.GetSummary();
        cycling1.GetSummary();

    }
}