using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{    
    static void Main(string[] args)
    {
        // intantiate classes
        Goal goal1 = new Goal();
        SimpleGoal simpleGoal1 = new SimpleGoal();




        int loop = -1;
        while (loop != 6)
        {
            // total points 
            Console.WriteLine($"You have {goal1.GetTotalPoints()} points");

            // menu options printed out
            Console.WriteLine("Menu Option:");
            Console.WriteLine(" 0. Add to existing file");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");


            // select from menu
            Console.WriteLine("Select a choice from the menu? ");
            string stringNum = Console.ReadLine();
            int userNum = int.Parse(stringNum);



            if (userNum == 1)
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");

                Console.WriteLine("Select a choice from the menu? ");
                string stringNum1 = Console.ReadLine();
                int userGuess = int.Parse(stringNum1);

                if (userGuess == 1)
                {
                    // infromation for each goal constructor
                    Console.WriteLine("What is the name of you mini goal: ");
                    string name = Console.ReadLine();

                    
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    string intString = Console.ReadLine();
                    int pointsNum = int.Parse(intString);

                    SimpleGoal simpleGoal2 = new SimpleGoal(pointsNum, description, name);

                    simpleGoal2.CreateNewGoal();
                }
                else if (userGuess == 2)
                {
                    // infromation for each goal constructor
                    Console.WriteLine("What is the name of you mini goal: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is a short descirpiton: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    string intString = Console.ReadLine();
                    int pointsNum = int.Parse(intString);

                    EternalGoal eternalGoal1 = new EternalGoal(pointsNum, description, name);

                    eternalGoal1.CreateNewGoal();
                }
                else if (userGuess == 3)
                {
                    // infromation for each goal constructor
                    Console.WriteLine("What is the name of you mini goal: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is a short descirpiton: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    string intString = Console.ReadLine();
                    int pointsNum = int.Parse(intString);

                    Console.WriteLine("How times does it need to be completed to be cheked off? ");
                    string stringRead = Console.ReadLine();
                    int  numOfChecks = int.Parse(intString);

                    CheckListGoal checkListGoal1 = new CheckListGoal(pointsNum, description, numOfChecks,name);

                    checkListGoal1.CreateNewGoal();
                }
            }
            else if (userNum == 2)
            {
                simpleGoal1.ListGoals();
            }
            else if (userNum == 3)
            {
                goal1.SaveGoals();
            }
            else if (userNum == 4)
            {
                goal1.LoadGoals();
            }
            else if (userNum == 5)
            {
                goal1.RecordEvent();
            }
            else
                // exit the loop
                loop = 6;

        }
    }
}