using System;

class Program
{
    static void Main(string[] args)
    {
        int startLoop = -1;
        while (startLoop != 0)
        {
            // Display menu options
            Console.WriteLine("Type coresponding number to choose");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Acitivity");
            Console.WriteLine("3. Refelction Acitivity");
            Console.WriteLine("4. Suggest a new activity");
            Console.WriteLine("5.  Quit");

            Console.WriteLine("");
            Console.WriteLine("Choose an activity: ");
            string user_input = Console.ReadLine();
            int user_num = int.Parse(user_input);

            // instaces of each Child class
            Activity activity1 = new Activity("Get Ready...","You have completed", 5);
            Listing listing1 = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",  20, "Get Ready...", "You have Completed");
            Reflection reflection1 = new Reflection("You have completed","Get Ready...", 6, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Breathing breathing1 = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", "Get Ready", "You have Completed", 6);
            NewActivity newActivity1 = new NewActivity();

            // if statement to choose
            if (user_num == 1)
            {
                breathing1.DisplayBreathingMessage();

            }
            else if (user_num == 2)
            {

                listing1.DisplayListingPrompts();

            }
            else if (user_num == 3)
            {

                reflection1.DisplayReflectionActivity();

            }
            else if (user_num == 4)
            {

                newActivity1.SuggestActivity();
            }
            else
            {
                startLoop = 0;
            }

        }
        
    }
}


