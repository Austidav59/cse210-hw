
using System.Runtime.CompilerServices;

public class Word
{
    Random rnd = new Random();

    Scripture scripture1 = new Scripture();

    Reference reference1 = new Reference();




    public void DeleteWords()
    {
        if (scripture1.GetCount() == 0)
        {
            reference1.SetReference("1 Nephi:1");
            reference1.SetReference("Alma 33:22");
            reference1.SetReference("Helaman 5:11-12");

            scripture1.SetVerses("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
            scripture1.SetVerses("If so, wo shall come upon you; but if not so, then cast about your eyes and begin to believe in the Son of God, that he will come to redeem his people, and that he shall suffer and die to atone for their sins; and that he shall rise again from the dead, which shall bring to pass the resurrection, that all men shall stand before him, to be judged at the last and judgment day, according to their works.");
            scripture1.SetVerses("And he hath power given unto him from the Father to redeem them from their sins because of repentance; therefore he hath sent his angels to declare the tidings of the conditions of repentance, which bringeth unto the power of the Redeemer, unto the salvation of their souls.12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

            // count list length
            int scriptureListsLength = scripture1.CountVerses();

            // generate Random Number 0 to list length
            int randomNumber = rnd.Next(0,scriptureListsLength);

            // Set Edited verse to list to edit with
            scripture1.SetEditedVerse($"{reference1.GetReference(randomNumber)} {scripture1.GetScriptureVerses(randomNumber)}");

            //Display list at prompt index.
            Console.WriteLine();
            Console.WriteLine($"{reference1.GetReference(randomNumber)} {scripture1.GetScriptureVerses(randomNumber)}");
            scripture1.AddCount();

        }
        else
        {
            // parse verse into a list of strings
            string editString = scripture1.GetEditedVerses();
            string[] stringSplit = editString.Split(" ");
            
            // add to a list
            foreach (string str in stringSplit)
            {
                scripture1.SetParsedVerse(str);
            }

            // count list length
            int parsedListsLength = scripture1.CountParsedList();

            // generate 3 Random Number 0 to list length
            int Num1 = rnd.Next(0,parsedListsLength);
            int num2 = rnd.Next(0,parsedListsLength);
            int Num3 = rnd.Next(0,parsedListsLength);

            //check numbers
            scripture1.CheckIndexUse(Num1);













        }
    } 
}