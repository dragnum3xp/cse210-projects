using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 41, 10);
        Scripture scripture = new Scripture(reference,"\n Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness");

        string userInput;
        bool completelyHidden;

        do
        {
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            completelyHidden = scripture.IsCompletelyHidden();
            int number = new System.Random().Next(0, 4);

            scripture.HideRandomWords(number);

        }while (userInput != "quit" && !completelyHidden);
    }
}
    