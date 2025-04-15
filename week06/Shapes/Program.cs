using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating different kinds of shapes and setting their colors
        Square squareShape = new Square("Blue", 5);
        Retangle retangleShape = new Retangle("Red", 5, 10);
        Circle circleShape = new Circle("White", 8);


        // Creating a list of Shapes and adding them to the same list
        List<Shape> shapes = new List<Shape> { squareShape, retangleShape, circleShape };

        // Get a custom calculation for each one
        foreach (Shape shape in shapes)
        {
            double shapeArea = shape.GetArea();
            Console.WriteLine($"The area of the {shape.GetColor()} shape is: {shapeArea}");
        }
    }
}