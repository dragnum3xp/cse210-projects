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

   }

   public string GetRandomPrompt()
   {
    //Prompts the user from a list of questions
    return "";
   }

   public string GetRandomQuestion()
   {
    
    return"";
   }

   public void DisplayPrompt()
   {

   }

   public void DisplayQuestions()
   {
    //Loop through questions after a period during the activity duration
   }
}
