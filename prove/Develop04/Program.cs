using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {   
        int user;
        do {
            Console.WriteLine("Welcome to the Mindfulness App. Choose one activity below: ");
            Console.WriteLine("1. Breathing Activity\n2. Refleting Activity\n3. Listing Activity\n4. Exit");
            user = Convert.ToInt32(Console.ReadLine());
                
            if (user == 1)
            {
                Breath breath = new Breath("Breathing activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.Run();

            }else if (user == 2)
            {   
                Reflect reflect = new Reflect("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.Run();

            }else if (user == 3)
            {

            }
                

        }while(user != 4);
    }
}