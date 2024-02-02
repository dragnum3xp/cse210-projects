using System.Runtime.ExceptionServices;

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
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void showSpinner(int seconds)
    {
        //Pause and spinning animation
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        /*animation.Add("|");
        animation.Add("");
        animation.Add("");
        animation.Add("");
        animation.Add("");*/
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {   
            Console.Write(animation[index]);
            if (index == 3){index = 0;}
            index = index + 1;
            Thread.Sleep(500);
            Console.Write("\b \b");
        }



    }

}