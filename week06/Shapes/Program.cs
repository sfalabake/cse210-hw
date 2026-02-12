using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Shape objects
        List<Shape> shapes = new List<Shape>();

        // Adding different shapes to the same list
        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 5, 10);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 3);
        shapes.Add(c1);

        Console.WriteLine("Shape Area Report:");
        Console.WriteLine("-------------------");

        // Iterate through the list and display results
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}