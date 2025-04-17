public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed() //Get speed in km/h 
    {
        double hours = _lengthInMinutes / 60.0;
        return _distance / (double)hours;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }
}