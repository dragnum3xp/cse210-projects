using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int n_number;
        int sum = 0;
        int count = 0;
        int highest = 0;
        int lowest = 99999;

        do
        {
            Console.WriteLine("Enter number: ");
            n_number = Convert.ToInt32(Console.ReadLine());
            if (n_number != 0)
            {
                numbers.Add(n_number);
            }
            

        } while (n_number != 0);

        foreach (int number in numbers)
        {
            sum += number;
            count += 1;
            if (number > highest)
            {
                highest = number;
                
            }

            if (number < lowest)
                if (number > 0)
                {
                    lowest = number;
                }

        };
        float average = sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highest}");
        Console.WriteLine($"The smallest positive number is: {lowest}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();

        foreach (int number in numbers)
        Console.WriteLine(number);

        
    }
}