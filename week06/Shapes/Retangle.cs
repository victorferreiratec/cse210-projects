public class Retangle : Shape
{
    private double _firstSide;
    private double _secondSide;

    public Retangle(string color, double firstSide, double secondSide) : base(color)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
    }

    public override double GetArea()
    {
        return _firstSide * _secondSide;
    }
}