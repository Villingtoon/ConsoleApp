using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; }
        public decimal Balance { get; } 
        public DateTime Created { get; }
        public string Currency { get; }


        public BankAccount(string owner, decimal balance, string accountNumber, DateTime created, string currency)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
            Created = created;
            Currency = currency;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.AccountNumber} created on {this.Created.ToShortDateString()} belongs to {this.Owner} and has a balance {this.Balance}{this.Currency}");
        }
    }
}
