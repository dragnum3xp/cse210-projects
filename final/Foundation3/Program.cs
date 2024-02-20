using System;

class Program
/* Names and places are abstract and do not represent any real data*/
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2020, 10, 20);
        Address address1 = new Address("456 Main St", "Anytown", "CA", "USA");
        Lectures event1 = new Lectures("Event", "Lecture with Maximus cornelium founder of catareck institution", date1, "16hs", address1, "Lecture", "Maximus Cornelium", 500);

        event1.standardDetails();
        Console.WriteLine();
        event1.fullDetails();
        Console.WriteLine();
        event1.shortDescription();
        Console.WriteLine("\n\n");

        DateTime date2 = new DateTime(2022, 11, 23);
        Address address2 = new Address("098 Main St", "Anytown", "TX", "USA");
        Receptions event2 = new Receptions("Reception for Cornelum", "The comemoration of the 100th aniverssary of the scollar Maximus cornelium", date2, "18hs","Reception", address2, "Register111@email.com");

        event2.standardDetails();
        Console.WriteLine();
        event2.fullDetails();
        Console.WriteLine();
        event2.shortDescription();
        Console.WriteLine("\n\n");

        DateTime date3 = new DateTime(2021, 09, 21);
        Address address3 = new Address("826 Main St", "Anytown", "UT", "USA");
        Outdoors event3 = new Outdoors("C# gathering", "Event to learn and share knowledge for brilhant minds", date3, "19hs", address3, "Outdoor", "Rainy");

        event3.standardDetails();
        Console.WriteLine();
        event3.fullDetails();
        Console.WriteLine();
        event3.shortDescription();



    


        
    }
}