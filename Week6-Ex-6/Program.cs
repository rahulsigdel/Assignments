using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> items;

    // Constructor
    public Stack()
    {
        items = new List<T>();
    }

    // Method to add an item to the top of the stack
    public void Push(T item)
    {
        items.Add(item);
    }

    // Method to remove and return the top item from the stack
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop an item.");
        }

        T poppedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    // Method to return the top item from the stack without removing it
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot peek at the top item.");
        }

        return items[items.Count - 1];
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Stack<int> class
        Stack<int> intStack = new Stack<int>();

        // Perform various push and pop operations
        intStack.Push(1);
        PrintStack(intStack);

        intStack.Push(2);
        PrintStack(intStack);

        intStack.Push(3);
        PrintStack(intStack);

        int poppedItem = intStack.Pop();
        Console.WriteLine($"Popped item: {poppedItem}");
        PrintStack(intStack);

        intStack.Push(4);
        PrintStack(intStack);

        int peekedItem = intStack.Peek();
        Console.WriteLine($"Peeked item: {peekedItem}");
        PrintStack(intStack);
    }

    // Helper method to print the remaining items in the stack
    static void PrintStack<T>(Stack<T> stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            Console.Write("Stack: ");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
