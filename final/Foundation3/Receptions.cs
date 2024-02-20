class Receptions : Event
{   
    private string _email;
    public Receptions(string title, string description, DateTime date, string time, string type, Address address, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public override void fullDetails()
    {
        Console.WriteLine($"{_title} \n{_description} \n{_date.ToString("MM/dd/yyyy")} at: {_time}\nAddress: {_address.GetFullAddress()}\nEmail for registration: {_email}");
    }
}