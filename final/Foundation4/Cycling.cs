using System.Globalization;

class Cycling : Activity
{   
    private double _speed;
    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _length) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
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
