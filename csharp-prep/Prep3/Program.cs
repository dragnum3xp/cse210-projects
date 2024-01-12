using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine("What is the magic number?");
        int guess;
        int attempts = 0;
        
        do
        {
            attempts += 1;
            Console.WriteLine("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != number);

        if (guess == number)
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It tooks {attempts} attempts");
        }
    }
}