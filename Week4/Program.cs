using System;

public class Car
{
    // Private properties
    private string brand;
    private int year;
    private float price;

    // Constructor
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    // Public method to print car details
    public void PrintCarDetails()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: {price:C}"); // Assuming the price is a currency value
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Car class
        Car myCar = new Car("Toyota", 2022, 25000.50f);

        // Print out the car details
        myCar.PrintCarDetails();
    }
}
