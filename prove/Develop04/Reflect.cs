public class Reflect : Activity
{   
    /*Holds the logic for the Reflect activity
    */
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

   public Reflect(string name, string description) : base(name, description)
   {
        
   }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Enter duration in seconds: ");
        int endTimeSeconds = Convert.ToInt32(Console.ReadLine());
        _duration = endTimeSeconds;
        DateTime endTime = DateTime.Now.AddSeconds(endTimeSeconds + 10);   

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(4);

        Console.WriteLine("Consider the following prompt: \n");
        DisplayPrompt();
        Thread.Sleep(3000);
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        string userInput = Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine($"You may begin in: ");
        CountdownTime(5);
        
        while (DateTime.Now < endTime){
            DisplayQuestions();
            showSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine("Well done!!");
        showSpinner(5);
        Console.WriteLine();
        endMessage();
        showSpinner(3);
        Console.Clear();



    }

      public string GetRandomPrompt()
      {
        //Prompts the user from a list of questions
          string prompt1 = "\n--- Think of a time when you felt very happy ---";
          string prompt2 = "\n--- Think of a time when you did something really difficult. ---";
          _prompts.Add(prompt1);
          _prompts.Add(prompt2);

          var random = new Random();
          int index = random.Next(_prompts.Count);
        
      return _prompts[index];
   }

   public string GetRandomQuestion()
   {
      string question1 = "\nWhat do you felt when the experience ends?";
      string question2 = "\nWhy did you chose this experience?";
      string question3 = "\n How this experience changed your life?";
      _questions.Add(question3);
      _questions.Add(question2);
      _questions.Add(question1);


      var random = new Random();
      int index = random.Next(_questions.Count);
      return _questions[index];

   }

   public void DisplayPrompt()
   {
      Console.WriteLine(GetRandomPrompt());
   }

   public void DisplayQuestions()
   {
    //Loop through questions after a period during the activity duration
    Console.WriteLine(GetRandomQuestion());
   }
}
