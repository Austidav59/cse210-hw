using System;




class Program
{
    static void Main(string[] args)
    {
        // making the scripture list
        List<string> scriptureList = new List<string>();
        scriptureList.Add("2 Nephi 32: 3 Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, bfeast upon the cwords of Christ; for behold, the words of Christ will dtell you all things what ye should do.");
        scriptureList.Add("Mosiah 4: 30 But this much I can tell you, that if ye do not awatch yourselves, and your bthoughts, and your cwords, and your deeds, and observe the commandments of God, and dcontinue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not.");
        scriptureList.Add("Alma 34: 32 For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors." + "33 And now, as I said unto you before, as ye have had so many witnesses, therefore, I beseech of you that ye do not procrastinate the day of your repentance until the end; for after this day of life, which is given us to prepare for eternity, behold, if we do not improve our time while in this life, then cometh the dnight of edarkness wherein there can be no labor performed." +
        "34 Ye cannot say, when ye are brought to that awful acrisis, that I will repent, that I will return to my God. Nay, ye cannot say this; for that same spirit which doth possess your bodies at the time that ye go out of this life, that same spirit will have power to possess your body in that eternal world.");
        scriptureList.Add("Ether 12: 27 And if men come unto me I will show unto them their aweakness. I bgive unto men weakness that they may be humble; and my cgrace is sufficient for all men that dhumble themselves before me; for if they humble themselves before me, and have faith in me, then will I make eweak things become strong unto them.");
        scriptureList.Add("Helaman 5: 12 And now, my sons, remember, remember that it is upon the arock of our Redeemer, who is Christ, the Son of God, that ye must build your bfoundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty cstorm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        // Display scrirpture from list
        int count = scriptureList.Count();
        Random rnd = new Random();
        int randscripture  = rnd.Next(count);
        Console.WriteLine(scriptureList[randscripture]);
        Console.WriteLine();

        // start while loop to compute edited sciptur and search for the enter key or quit
        Console.WriteLine("Press Enter to contniue and then any other key to exit");
        while (Console.ReadKey().Key == ConsoleKey.Enter) 
        {
                    
            Console.WriteLine("hi yo");

        }

        Console.WriteLine();
        Console.WriteLine("Thank you for memorizing");





    }
}

