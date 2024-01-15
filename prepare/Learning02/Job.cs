
public class Job {
    
    public string _company = "";
    public string _jobtitle = "";
    public int _startYear;
    public int _endYear;

    public void DysplayInformation()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");
    }

}