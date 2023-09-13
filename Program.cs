class Program{
    static void DisplayAccountDetails(Account account8){
        Console.WriteLine($"Account Number: {account8.AccountNumber}");
        Console.WriteLine($"Balance: ${account8.Balance}");
    }
    static void Main(string [] args){
        SavingsAccount savingsAccount = new SavingsAccount(1500, 34.0);
        CheckingAccount checkingAccount = new CheckingAccount(1999,24.0);

        savingsAccount.Deposit(5000);
        DisplayAccountDetails(savingsAccount);
        savingsAccount.CalculateInterest();
        DisplayAccountDetails(savingsAccount);

        Console.WriteLine();

        checkingAccount.Deposit(100);
        DisplayAccountDetails(checkingAccount);
        checkingAccount.Withdraw(600);
        DisplayAccountDetails(checkingAccount);
    }
}