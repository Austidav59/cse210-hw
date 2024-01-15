using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // log instructions to console
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine();

        // initialize usernumber
        int userNumber = -1000;

        // list object
        List<int> numberList = new List<int>();

        while (userNumber != 0) 
        {
            // Enter number question
            Console.WriteLine("Enter Number: ");
            string enterNum = Console.ReadLine();
            userNumber = int.Parse(enterNum);

            // Add number to list
            numberList.Add(userNumber);
        }
        Console.WriteLine($"The sum of the list is: {numberList.Sum()}");
        Console.WriteLine($"The average of the list is {numberList.Average()}");
        Console.WriteLine($"The Hhighest number is: {numberList.Max()}");




        
    }
}