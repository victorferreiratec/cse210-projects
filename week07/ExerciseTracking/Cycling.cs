public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }


    public override double GetDistance()
    {
        return _lengthInMinutes * _speed / 60;
    }

    public override double GetSpeed() //Get speed in km/h 
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}