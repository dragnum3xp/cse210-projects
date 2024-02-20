using System.Reflection;

class Event 
{
    protected  string _description;
    protected string _title;
    protected  DateTime _date;
    protected  string _time;
    protected Address _address;
    protected string _type;

    /*protected string _address;*/

    public Event(string title, string description, DateTime date, string time,Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }


    public void standardDetails()
    {
        
        Console.WriteLine($"{_title}\n{_description}\n{_date.ToString("MM/dd/yyyy")} at: {_time}\nAddress: {_address.GetFullAddress()}");
    }

    public virtual void fullDetails()
    {

    }

    public void shortDescription()
    {
        Console.WriteLine($"Event Type: {_type}\nEvent Title: {_title}\nDate: {_date.ToString("MM/dd/yyyy")}");
    }

}
