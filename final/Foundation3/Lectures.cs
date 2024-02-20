using System.ComponentModel;

class Lectures : Event
{   
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, DateTime date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time,address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void fullDetails()
    {
        Console.WriteLine($"{_title} \n{_description} \n{_date.ToString("MM/dd/yyyy")} at: {_time} \nSpeaker: {_speaker} \nCapacity: {_capacity}\nAddress: {_address.GetFullAddress()}");
    }
}   
