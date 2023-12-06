using System;

public class Shape
{
    // Virtual method to calculate the area (returns 0 by default)
    public virtual float CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    // Public property for the radius
    public float Radius { get; set; }

    // Override the CalculateArea method for a circle
    public override float CalculateArea()
    {
        return (float)(Math.PI * Math.Pow(Radius, 2));
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Circle class with a radius of 5
        Circle myCircle = new Circle
        {
            Radius = 5
        };

        // Call the CalculateArea method and print out the result
        float area = myCircle.CalculateArea();
        Console.WriteLine($"The area of the circle is: {area}");
    }
}
