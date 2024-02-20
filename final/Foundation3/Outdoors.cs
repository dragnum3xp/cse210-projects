class Outdoors : Event
{   
    private string _wheater;
    public Outdoors(string title, string description, DateTime date, string time, Address address, string type, string wheater) : base(title, description, date, time, address, type)
    {
        _wheater = wheater;
    }

    public override void fullDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date.ToString("MM/dd/yyyy")} at: {_time}\nAddress: {_address.GetFullAddress()}\nWheater prevision: {_wheater}");
    }
}