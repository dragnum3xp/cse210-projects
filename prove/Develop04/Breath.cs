using System.Diagnostics;
using System.Security.Principal;

public class Breath : Activity
{
   
   public Breath(string name, string description) : base(name, description)
   {

   }
   public void Run()
   {
      DisplayStartingMessage();
      Console.WriteLine("Enter duration in seconds: ");
      int endTimeSeconds = Convert.ToInt32(Console.ReadLine());
      _duration = endTimeSeconds;
      DateTime endTime = DateTime.Now.AddSeconds(endTimeSeconds + 4);   
      
      Console.WriteLine("Get ready...");
      showSpinner(4);
      do
      {  
         Console.WriteLine("\nBreath in");
         CountdownTime(6);
         Console.WriteLine("\nNow Breath out");
         CountdownTime(4);
         
      }while (DateTime.Now < endTime);
      Console.WriteLine("Well done!!");
      showSpinner(5);
      Console.WriteLine();
      endMessage();
      showSpinner(3);
      Console.WriteLine();
      
   }
}