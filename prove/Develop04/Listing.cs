public class Listing : Activity
{
    /*Holds the logic for the Listing activity*/
    private List<string> _prompts;
    private int _count = 0;

    public Listing(string name, string description) : base(name, description)
   {
    
   }
    public void Run()
   {

   }

   public string GetRandomPrompt()
   {
    //Display a random prompt
    return "";
   }

   /*public List<string> GetListFromUser()
   {
    //Hold a List of entries
    return;
   }*/
}