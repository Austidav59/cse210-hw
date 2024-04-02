using System;

class Program
{
    static void Main(string[] args)
    {
        Reception reception1 = new Reception("dan&emilywedding@gmail.com",true,"Dan & Emily Wedding","Come celebrate with us the marrage of Dan and Emily","6:00 pm", "1234, loopy street, Salt Lake City, Utah","Reception");
        Lecture lecture1 = new Lecture("Dr, John splileno",150,"Atoms to Humans","Come learn about the science of our begining","7:30 AM",  "385672 universtiy ave, South Jordan, Utah", "Lecture");
        Outdoor outdoor1 = new Outdoor("Sunny with Cloud overcast","Mikes 50th Birthday!","Come celebrate Mikes turning the big 50 this year!","4:00 PM", "Pioneer park,  West Jordan, 89654, Utah", "Outdoor Gathering");


        //RECEPTION Display Details
        Console.WriteLine("Reception Display Details");
        reception1.ShortDescrition();
        reception1.StandardDetails();
        reception1.DispslayFullDetails();

        //Outdoor Display Details
        Console.WriteLine("Outdoor Display Details");
        outdoor1.ShortDescrition();
        outdoor1.StandardDetails();
        outdoor1.DisplayFullDetails();

        //Lecture Display Details
        Console.WriteLine("Lecture Display Details");
        lecture1.ShortDescrition();
        lecture1.StandardDetails();
        lecture1.DisplayFullDetails();

    }
}