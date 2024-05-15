// See https://aka.ms/new-console-template for more information
using ConsoleBankApp;

List<Account> accounts = [];

Console.WriteLine("\t\t\t Welcome to my Bank App!");

while (true)
{
    DisplayMenu();

    int choice = GetChoice();

    switch (choice)
    {
        case 1:
            CreateSavingsAccount(accounts);
            break;

        case 2:
            CreateCurrentAccount(accounts);
            break;

        case 3:
            Deposit(accounts);
            break;

        case 4:
            Withdraw(accounts);
            break;

        case 5:
            DisplayBalances(accounts);
            break;

        case 6:
            Console.WriteLine("Exiting the application...");
            return;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

static void DisplayMenu()
{
    Console.WriteLine("\n1. Create Savings Account");
    Console.WriteLine("2. Create Current Account");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Withdraw");
    Console.WriteLine("5. View Balance");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");
}

static int GetChoice()
{
    return Convert.ToInt32(Console.ReadLine());
}

static void CreateSavingsAccount(List<Account> accounts)
{
    Console.Write("Enter account number for Savings Account: ");
    int savingsAccountNumber = Convert.ToInt32(Console.ReadLine());
    accounts.Add(new SavingsAccount(savingsAccountNumber));
    Console.WriteLine("Savings Account created successfully!");
}

static void CreateCurrentAccount(List<Account> accounts)
{
    Console.Write("Enter account number for Current Account: ");
    int currentAccountNumber = Convert.ToInt32(Console.ReadLine());
    accounts.Add(new CurrentAccount(currentAccountNumber));
    Console.WriteLine("Current Account created successfully!");
}
static void Deposit(List<Account> accounts)
{
    Console.Write("Enter account number: ");
    int accountNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter deposit amount: ");
    decimal amount = Convert.ToDecimal(Console.ReadLine());

    Account account = FindAccount(accounts, accountNumber);

    if (account != null)
    {
        account.Deposit(amount);
    }
    else
    {
        Console.WriteLine("Account not found.");
    }
}

static void Withdraw(List<Account> accounts)
{
    Console.Write("Enter account number: ");
    int accountNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter withdrawal amount: ");
    decimal amount = Convert.ToDecimal(Console.ReadLine());

    Account account = FindAccount(accounts, accountNumber);

    if (account != null)
    {
        account.Withdraw(amount);
    }
    else
    {
        Console.WriteLine("Account not found.");
    }
}

static void DisplayBalances(List<Account> accounts)
{
    Console.WriteLine("\nAccount Balances:");
    foreach (var account in accounts)
    {
        account.DisplayBalance();
    }
}

static Account FindAccount(List<Account> accounts, int accountNumber)
{
    foreach (var account in accounts)
    {
        if (account.AccountNumber == accountNumber)
        {
            return account;
        }
    }
    return null;
}
