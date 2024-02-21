using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {   
        Activity[] activities = new Activity[]
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };
        
        foreach (var Activity in activities)
        {
            Console.WriteLine(Activity.GetSummary());
        }
    }
}