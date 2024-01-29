using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(writing1.GetWritingInformation());
    }
}