public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;

    // Constructor to initialize the fields
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F2} min per km";
    }


}