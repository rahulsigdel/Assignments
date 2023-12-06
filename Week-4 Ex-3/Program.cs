using System;

public class Rectangle
{
    // Private properties
    private float length;
    private float width;

    // Constructor
    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    // Method to calculate the area of the rectangle
    public float CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Rectangle class
        Rectangle myRectangle = new Rectangle(4.5f, 3.2f);

        // Call the CalculateArea method and print out the result
        float area = myRectangle.CalculateArea();
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}

