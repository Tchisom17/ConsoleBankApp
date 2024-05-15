using System;
using System.Collections.Generic;

// Abstraction: defining abstract classes and methods
public abstract class Account
{
    public int AccountNumber { get; protected set; }
    public decimal Balance { get; protected set; }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
    public abstract void DisplayBalance();
}

// Encapsulation: hiding internal details of Account types
public class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"You deposited {amount}. New balance: {Balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"You withdrew {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public override void DisplayBalance()
    {
        Console.WriteLine($"Savings Account Number: {AccountNumber}, Balance: {Balance}");
    }
}

public class CurrentAccount : Account
{
    public CurrentAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public override void DisplayBalance()
    {
        Console.WriteLine($"Current Account Number: {AccountNumber}, Balance: {Balance}");
    }
}
