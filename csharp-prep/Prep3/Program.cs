using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("What is magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        int userGuess = -1;
        
        while (userGuess != number) 
        {
            Console.WriteLine("What is your guess? ");
            string userNumber = Console.ReadLine();
            userGuess = int.Parse(userNumber);

            if (userGuess > number)
            {
                Console.WriteLine("Too High");
            }
            else if (userGuess < number)
            {
                Console.WriteLine(" Too Low");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            };
        }
    }
}