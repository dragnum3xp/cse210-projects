using System.Globalization;

class Swimming : Activity
{   
    private int _laps;
    
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return ((_laps * 50.0) / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}- Distance: {GetDistance().ToString("0.0", CultureInfo.InvariantCulture)} miles, Speed {GetSpeed().ToString("0.0", CultureInfo.InvariantCulture)} mph, Pace: {GetPace().ToString("0.0", CultureInfo.InvariantCulture)} min/mile";
    }
}