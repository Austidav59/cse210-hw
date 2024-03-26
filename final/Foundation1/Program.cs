using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 =  new Video();

        //Video Titles
        video1._title.Add("Top ten most expensive cars");
        video1._title.Add("Toy car Review");
        video1._title.Add("Hide and seek in a mall");
        video1._title.Add("Paris Vlog");

        // video Length
        video1._length.Add(10);
        video1._length.Add(14);
        video1._length.Add(17);
        video1._length.Add(8);

        // Video Creator
        video1._author.Add("MrBeast");
        video1._author.Add("Yes Theory");
        video1._author.Add("Drone scopes");
        video1._author.Add("Jonny and Jane");
        
        // Display all video info
        video1.DisplayVideo();


    }
}