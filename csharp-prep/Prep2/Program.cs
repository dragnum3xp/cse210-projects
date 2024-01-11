using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please submit your Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score > 70)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Not passed!");
        }
        
        if (score >= 90)
        {
            if (score >= 97)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (score < 93)
            {
                Console.WriteLine("Grade: A-"); 
            }
            else {
                Console.WriteLine("Grade: A");
            }
        }
        else if (score <= 90)
        {
            if (score >= 87)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (score < 83)
            {
                Console.WriteLine("Grade: B-"); 
            }
            else {
                Console.WriteLine("Grade: B");
            }
        }
        else if (score <= 80)
        {
            if (score >= 77)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (score < 73)
            {
                Console.WriteLine("Grade: C-"); 
            }
            else {
                Console.WriteLine("Grade: C");
            }
        }
        else if (score <= 70)
        {
            if (score >= 67)
            {
                Console.WriteLine("Grade: D+");
            }
            else if (score < 63)
            {
                Console.WriteLine("Grade: D-"); 
            }
            else {
                Console.WriteLine("Grade: D");
            }
        }
        if (score < 60)
        {
            Console.WriteLine("Grade: F");
        }
    }
}