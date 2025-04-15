public abstract class Shape
{
    public string _color;
    public abstract double GetArea();

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // I only created a getter here because I don't really think is necessary for this program
    // specially because we already have a constructor for it.
}