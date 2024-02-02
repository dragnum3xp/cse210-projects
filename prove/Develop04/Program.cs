using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {   
        int user;
        int count = 0;
        do {
            Console.WriteLine("Welcome to the Mindfulness App. Choose one activity below: ");
            Console.WriteLine("1. Breathing Activity\n2. Refleting Activity\n3. Listing Activity\n4. Show how many exercises you made today.\n5. Exit");
            user = Convert.ToInt32(Console.ReadLine());
                
            if (user == 1)
            {   
                count = count + 1; 
                Breath breath = new Breath("Breathing activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.Run();

            }else if (user == 2)
            {   
                count = count + 1; 
                Reflect reflect = new Reflect("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.Run();

            }else if (user == 3)
            {   
                count = count + 1; 
                Listing Listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in centain area.");
                Listing.Run();

            }else if (user == 4)
            {   
                if (count == 1){
                    Console.WriteLine($"\nGood job you did {count} exercise today\n");}
                else if (count == 2){
                    Console.WriteLine($"\nGreat! you did {count} exercises today\n");}
                else if (count >= 3){
                    Console.WriteLine($"\nAmazing!! you did {count} exercises today, your body and mind should be very glad\n");}
                else {
                    Console.WriteLine("\nYou need to take care of yourself... You didn't made any Exercises Yet\n");}
                

            }
                

        }while(user != 5);
    }
}