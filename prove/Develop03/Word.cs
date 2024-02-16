
using System.Runtime.CompilerServices;
using System.Linq;

public class Word
{

    Random rnd = new Random();

    private List<string> _parsedWordsToEdit = new List<string>();


    private List<int> _indexesReplaced = new List<int>();

    private int count = 0;

    int randomReference = 0;
    // reference strings and objects created
    string reference1 = "1 Nephi:1";
    string reference2 = "Alma 33:22";
    string reference3 = "Helaman 5:11-12";

    public void DeleteWords()
    {
        if (count == 0)
        {

            //set values

            Reference refer1 = new Reference(reference1,1);
            Reference refer2 = new Reference(reference2,2);
            Reference refer3 = new Reference(reference3,3);

            // string verses and  verse object lists created.
            string verse1 = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
            string verse2 = "If so, wo shall come upon you; but if not so, then cast about your eyes and begin to believe in the Son of God, that he will come to redeem his people, and that he shall suffer and die to atone for their sins; and that he shall rise again from the dead, which shall bring to pass the resurrection, that all men shall stand before him, to be judged at the last and judgment day, according to their works.";
            string verse3 = "And he hath power given unto him from the Father to redeem them from their sins because of repentance; therefore he hath sent his angels to declare the tidings of the conditions of repentance, which bringeth unto the power of the Redeemer, unto the salvation of their souls.12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";

            // intatiate each object
            Scripture scripture1 = new Scripture(verse1,1);
            Scripture scripture2 = new Scripture(verse2,2);
            Scripture scripture3 = new Scripture(verse3, true);
                // generate Random Number 0 to list length
            int randomNumber1 = rnd.Next(0,2);
            randomNumber1 = randomReference;

            if (randomNumber1 == 0)
            {
                Console.WriteLine($"{reference1} {verse1}");

                foreach (string word in verse1.Split(" "))
                {
                    _parsedWordsToEdit.Add(word);
                }
            }
            else if ( randomNumber1 == 1)
            {
                Console.WriteLine($"{reference2} {verse2}");

                foreach (string word in verse2.Split(" "))
                {
                    _parsedWordsToEdit.Add(word);
                }
            }
            else
            {
                Console.WriteLine($"{reference3} {verse3}");

                foreach (string word in verse3.Split(" "))
                {
                    _parsedWordsToEdit.Add(word);
                }
            }



                count = count + 1;
        }
        else
        {
            //counted length of parsed list
           int counted = _parsedWordsToEdit.Count();



           for (int i = 0; i < counted ; i++ )
           {
            _indexesReplaced.Add(i);
           }

            int loop = 0;

           while (loop != 3)
           {
                int indexCounted = _indexesReplaced.Count();
                int randNumCount = rnd.Next(0,indexCounted + 1);
                foreach (int num in _indexesReplaced)
                {
                    if (randNumCount == num)
                    {
                        _indexesReplaced.Remove(randNumCount);
                        string indexChanged = _parsedWordsToEdit[randNumCount];
                        foreach (string Word in _parsedWordsToEdit)
                        {
                            if (Word == indexChanged)
                            {
                                _parsedWordsToEdit[randNumCount] = "___";
                                loop =  loop + 1;
                                break;
                            }
                        }
                        break;

                    }
                }
           }
            
            // Congregate lsit and display
            if (_indexesReplaced.Count() > 0 )
            {
                string editeVerse = _parsedWordsToEdit.Aggregate((current, next) => current + " " + next);
                if (randomReference == 0)
                {
                    Console.WriteLine($"{reference1} {editeVerse}");
                }
                else if (randomReference == 1)
                {
                    Console.WriteLine($"{reference2} {editeVerse}");
                }
                else
                {
                    Console.WriteLine($"{reference3} {editeVerse}");
                }
                
            }










        }









    }







}
