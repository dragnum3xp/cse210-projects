public class Listing : Activity
{
    /*Holds the logic for the Listing activity*/
    private List<string> _prompts = new List<string>();
    private int _count = 0;

    public Listing(string name, string description) : base(name, description)
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

        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine($"You may begin in: ");
        CountdownTime(5);
         List<string> entries = GetListFromUser();
        while (DateTime.Now < endTime)
        {    
            string entry = Console.ReadLine();
            _count += 1;
            entries.Add(entry);
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
    //Display a random prompt
        string prompt1 = "\n--- When you have felt the Holy Ghost this month? ---";
        string prompt2 = "\n--- How and When did you saw the hand of the Lord tis week?. ---";
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);

        var random = new Random();
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    
   }

   public List<string> GetListFromUser()
   {        
        List<string> entries = new List<string>();
        

        //Hold a List of entries
        return entries;
   }
}