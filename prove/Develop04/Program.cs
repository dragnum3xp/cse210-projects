using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App. Choose one activity below: ");
        Console.WriteLine("1. Breathing\n2. Refleting\n3. Listing\n4. Exit");
        int user = Convert.ToInt32(Console.ReadLine());
        do {
                if (user == 1)
                {
                   Breath breath = new Breath("Breathing activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
                   breath.Run();

                }else if (user == 2)
                {

                }else if (user == 3)
                {

                }
                

        }while (user != 4);
    }
}