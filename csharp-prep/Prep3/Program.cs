using System;

class Program
{
    static void Main(string[] args)
    {

        // program picks a randome number
        Random randomGenerator = new Random();
        int rand = randomGenerator.Next(1, 10);

        // starts the while loop
        bool input = true;
        while (input == true)
        {
            Console.Write("What number do you want to guess? ");
            string nums = Console.ReadLine();
            int guess = int.Parse(nums);

            if (guess > rand)
            {
                Console.WriteLine("Too High");
            }
            else if (guess < rand)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                input = false;
            }
        }
            
    
    }
}