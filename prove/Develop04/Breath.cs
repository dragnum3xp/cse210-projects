using System.Diagnostics;

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
      DateTime endTime = DateTime.Now.AddSeconds(endTimeSeconds);   
      
      Console.WriteLine("Get ready");
      for (int i = 4; i > 0; i--)
      {
         Console.Write(".");
         Thread.Sleep(1000);

      }
      
      do
      {  
         Console.WriteLine("\nBreath in");
         CountdownTime(6);
         Console.WriteLine("\nNow Breath out");
         CountdownTime(4);
         
      }while (DateTime.Now < endTime);
      
      endMessage();
      
      Console.WriteLine();
   }
}