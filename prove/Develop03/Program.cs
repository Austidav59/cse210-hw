using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // intances of each class
        Word word1 = new Word();

        Scripture scripture1 = new Scripture();
        scripture1.SetVerses("1 Nephi:1");
        scripture1.SetVerses("Alma 33:22");
        scripture1.SetVerses("Helaman 5:11-12");

        Reference reference1 = new Reference();
        reference1.SetReference("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
        reference1.SetReference("If so, wo shall come upon you; but if not so, then cast about your eyes and begin to believe in the Son of God, that he will come to redeem his people, and that he shall suffer and die to atone for their sins; and that he shall rise again from the dead, which shall bring to pass the resurrection, that all men shall stand before him, to be judged at the last and judgment day, according to their works.");
        reference1.SetReference("And he hath power given unto him from the Father to redeem them from their sins because of repentance; therefore he hath sent his angels to declare the tidings of the conditions of repentance, which bringeth unto the power of the Redeemer, unto the salvation of their souls.12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        string enterLoop = "enter";

        while (enterLoop != "quit")
        {

            Console.WriteLine("Enter y to continue");
            Console.WriteLine("Enter n to quit");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            string userInput = Console.ReadLine();

            if (userInput == "y")
            {

                word1.DeleteWords();

            }
            else
            {
                enterLoop = "quit";
            }
        
        }
    }
}