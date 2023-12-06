using System;

public class BankAccount
{
    // Private properties
    private string accountNumber;
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0; // Default balance is set to 0
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal not allowed.");
        }
        else
        {
            balance -= amount;
        }
    }

    // Method to print the current balance
    public void PrintBalance()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: {balance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the BankAccount class
        BankAccount myAccount = new BankAccount("123456789");

        // Deposit 1000 units
        myAccount.Deposit(1000);

        // Withdraw 500 units
        myAccount.Withdraw(500);

        // Print out the final balance
        myAccount.PrintBalance();
    }
}
