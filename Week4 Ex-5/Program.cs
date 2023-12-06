using System;

public class Student
{
    // Private properties
    private string name;
    private int age;
    private string major;

    // Constructor
    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    // Method to introduce the student
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {name}, {age} years old, and my major is {major}.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Student class
        Student johnDoe = new Student("John Doe", 20, "Computer Science");

        // Call the Introduce method
        johnDoe.Introduce();
    }
}

