using DesignPatterns;

BankAccount account = new BankAccount(100);
account.GetBalance();
account.Deposit(500);
account.GetBalance();
account.Withdraw(100);
account.GetBalance();