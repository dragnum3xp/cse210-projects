using System;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal");
        int user;
        Journal main = new Journal();
        //main._entries = 
        do 
        {
            Console.WriteLine("Choose one option: ");

            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal");
            Console.WriteLine("4. Load a Journal");
            Console.WriteLine("5. Exit");
            user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                Entry Entry = new Entry();
                var random = new PromptGenerator();
                Entry._prompt = random.ChooseRandom("C:/Users/Filip/OneDrive/Desktop/cse210-projects/cse210-projects/prove/Develop02/Prompts.csv");
                Console.WriteLine(Entry._prompt);
                Console.WriteLine("Answer: ");
                string answer = Console.ReadLine();
                Entry._answer = answer;
                DateTime CurrentTime = DateTime.Now;
                string dateText = CurrentTime.ToShortDateString();
                Entry._date = dateText;
                main.AddEntry(Entry);
                Console.WriteLine(main);

                
            };


        } while (user != 5);




        //Journal jornal = new Journal();

    }
}