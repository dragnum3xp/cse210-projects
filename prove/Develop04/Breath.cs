using System.Diagnostics;

public class Breath : Activity
{
   
   public Breath(string name, string description) : base(name, description)
   {

   }
   public void Run()
   {
      DisplayStartingMessage();
      int time = Convert.ToInt32(Console.ReadLine());
      activityDuration(time);
      endMessage();
   }
}