using System.Runtime.ExceptionServices;
using System.Threading;
public class Activity{
    
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    

    public void DisplayStartingMessage()
    {   
        //Display the title and description
        Console.WriteLine($"Welcome to the {_name}\n \n{_description}");
        Console.WriteLine("\nHow long, in seconds, would you like for your section? ");

        /*string infoReflect = "Welcome to the Reflecting Activity.\n \nThis activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n \nHow long, in seconds, would you like for your section?";

        string infoListing = "Welcome to the Listing Activity.\n \nThis activity will help you reflect on the good things in your life by having you list as many things as you can in centain area.\n \nHow long, in seconds, would you like for your section?";
        */
    }

    public void endMessage()
    {   
        //Take care of the end messages

        Console.WriteLine($"\nCongratulations, you finish {_duration} seconds of {_name}");
    }

    public void CountdownTime(int seconds)
    {
        //A method for countdown
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void showSpinner(int seconds)
    {
        //Pause and spinning animation
    }

}