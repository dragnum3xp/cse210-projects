using System.Globalization;

class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int length,double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}- Distance: {_distance.ToString("0.0", CultureInfo.InvariantCulture)} miles, Speed {GetSpeed().ToString("0.0", CultureInfo.InvariantCulture)} mph, Pace: {GetPace().ToString("0.0", CultureInfo.InvariantCulture)} min/mile";
    }
}