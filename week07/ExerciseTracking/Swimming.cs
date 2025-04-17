public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _numberOfLaps = laps;
    }

    public override double GetDistance() //The length of a lap in the lap pool is 50 meters.
    {
        return _numberOfLaps * 50;
    }

    public override double GetSpeed() //Get speed in km/h 
    {
        double distance = GetDistance() / 1000;
        double hours = _lengthInMinutes / 60.0;
        return distance / hours;
    }

    public override double GetPace()
    {
        double distance = GetDistance() / 1000;
        return _lengthInMinutes / distance;
    }
    
}