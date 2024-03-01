
public class Reflection : Activity
{
    Random rnd = new Random();
    private string _name;

    private string _description;

    List<string>refelctionPrompts =  new List<string>{
            "Think of a time when you did somthing really dificult",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    List<string>questionList =  new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    public Reflection(string endMessage, string startMessage, int duration, string name, string description) : base(startMessage,endMessage ,duration)
    {
        
        _description = description;

        _name = name;

    }


    public string GetRandomPrompt()
    {
        // count list
        int promptCounted = refelctionPrompts.Count();

        // Random number from list
        int randPromptNum = rnd.Next(0,promptCounted);

        string randPrompt = refelctionPrompts[randPromptNum];
        return randPrompt;

    }

    public string GetRandomQuestion()
    {
        //Count List
        int questionCounted = questionList.Count();

        //Random number from list
        int randQuestionNum = rnd.Next(0,questionCounted);

        string randQuestion = questionList[randQuestionNum];
        return randQuestion;
    }

    public void DisplayReflectionActivity()
    {
        // Display start message
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();

        // description 
        Console.WriteLine(_description);
        Console.WriteLine();

        // question for duration:
        Console.WriteLine("How long in seconds, would you like for your session? ");
        string stringDuration = Console.ReadLine();
        int numDuration = int.Parse(stringDuration);

        //turn user input into thread seconds
        int miliseconds = numDuration * 1000;

        // Get ready page
        DisplayStartMessage();
        PauseToShowSpinner();

        int startLoop = -1;
        while (startLoop != 0)
        {
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, Enter y to continue: ");
            string enter = Console.ReadLine();

            if (enter == "y")
            {
                Console.WriteLine("Now Ponder on each of the folowiing questions as thehy related to this experience. ");
                Console.WriteLine($"You may begin in: ");
                PauseCountdown();
                Console.WriteLine("");
                Console.WriteLine("");
                startLoop = 0;
            }

        }

        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine();
        Thread.Sleep(miliseconds);
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine();
        Thread.Sleep(miliseconds);
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine();

        Thread.Sleep(miliseconds);
        Console.WriteLine();

        Console.WriteLine("Well Done!");
        Console.WriteLine();

        Console.WriteLine($" {_endMessage} another 30 seconds of the Refelcting Activity ");
        Console.WriteLine();
        Thread.Sleep(miliseconds);

    }

}