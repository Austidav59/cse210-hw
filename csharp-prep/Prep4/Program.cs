using System;

class Program
{
    static void Main(string[] args)
    {
        // create the List
        List<int> numbers = new List<int>();   

        // start the while loop to append to list
        Console.WriteLine("Type 0 when finished adding number to list");
        bool input = true;
        while (input == true)
        {
            // ask for number to add to the list
            Console.Write("What number would you like to add to the list? ");
            string nums = Console.ReadLine();
            int addnum = int.Parse(nums);

            // add number to list
            numbers.Add(addnum);

            if (addnum == 0)
            {
                input = false;
            }
        }

        // sum
        var sum = numbers.Sum();
        Console.WriteLine($"The sum of the list is {sum}");

        // average
        var count = numbers.Count();
        var average = sum / count;
        Console.WriteLine($"The average of the list is {average}");

        // largest number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");






    }
}