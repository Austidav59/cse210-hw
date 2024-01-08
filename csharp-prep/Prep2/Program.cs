using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 90)
        {
            Console.WriteLine("A");
            Console.WriteLine("You Passed");
        }
        else if (number >= 80)
        {
            Console.WriteLine("B");
            Console.WriteLine("You Passed");
        }
        else if (number >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine("You Passed");
        }
        else if (number >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine("Keep Going You can do it");
        }
        else
        {
            Console.WriteLine("F");
            Console.WriteLine("Keep Going You can do it");
        }

    }
}