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
    }

    public string endMessage()
    {   
        //Take care of the end messages
        return "";
    }

    public void activityDuration(int seconds)
    {
        //A method for the duration of the activity
        
    }

    public void showSpinner(int seconds)
    {
        //Pause and spinning animation
    }
}