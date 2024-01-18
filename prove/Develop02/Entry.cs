using System;

public class Entry{

    public string _prompt;

    public string _answer;

    public string _date;


    public void Display()
    {
        Console.WriteLine($"prompt: {_prompt} Answer: {_answer} Date:{_date}");
    }
}

