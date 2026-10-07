using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Iitial balance cannot be negative");
            }
            this.balance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine($"Current balance is: {balance}");
        }
     public void Deposit(decimal amount)
        {
            if (balance <= 0)
            {
                throw new ArgumentException("Deposit cannoy be negative or zero");
            }
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw amount cannot be negative or zero");
            }
            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            this.balance -= amount;
        }
    }
}
