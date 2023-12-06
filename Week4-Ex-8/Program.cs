using System;

// Struct representing a 2-dimensional point
public struct Point2D
{
    public float X { get; set; }
    public float Y { get; set; }
}

// Class with a method to calculate the Euclidean distance between two Point2D objects
public class DistanceCalculator
{
    public static float CalculateDistance(Point2D point1, Point2D point2)
    {
        float deltaX = point2.X - point1.X;
        float deltaY = point2.Y - point1.Y;

        // Euclidean distance formula: sqrt((x2 - x1)^2 + (y2 - y1)^2)
        return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

class Program
{
    static void Main()
    {
        // Create two instances of the Point2D struct
        Point2D point1 = new Point2D { X = 1.0f, Y = 2.0f };
        Point2D point2 = new Point2D { X = 4.0f, Y = 6.0f };

        // Calculate the distance between the two points using the CalculateDistance method
        float distance = DistanceCalculator.CalculateDistance(point1, point2);

        // Print out the result
        Console.WriteLine($"The distance between the points is: {distance}");
    }
}
