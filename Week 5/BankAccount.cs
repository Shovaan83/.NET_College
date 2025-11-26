using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_5
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            if (initialBalance > 0)
            {
                balance = initialBalance;
            }
            else
            {
                balance = 0;
            }
        }

        public string accountNum
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }

            private set{
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
}
