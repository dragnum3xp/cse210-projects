using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction math1 = new Fraction();
        
        Console.WriteLine(math1.GetFractionString());
        Console.WriteLine(math1.GetDecimalValue());
        
        Fraction math2 = new Fraction(5);
        Console.WriteLine(math2.GetFractionString());
        Console.WriteLine(math2.GetDecimalValue());

        Fraction math3 = new Fraction(3, 4);
        Console.WriteLine(math3.GetFractionString());
        Console.WriteLine(math3.GetDecimalValue());

        Fraction math4 = new Fraction(1, 3);
        Console.WriteLine(math4.GetFractionString());
        Console.WriteLine(math4.GetDecimalValue());

        
        }
    }
