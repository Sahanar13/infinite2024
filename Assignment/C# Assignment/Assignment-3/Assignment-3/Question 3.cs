using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

   
    class InsufficientBalanceException : Exception
    {
       
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        public string AccountType { get; }

        
        public InsufficientBalanceException(int accountNumber, string accountHolderName, string accountType)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            AccountType = accountType;
        }

        
        public override string Message
        {
            get
            {
                return $"Insufficient balance in account {AccountNumber} of {AccountHolderName}. Account Type: {AccountType}.";
            }
        }
    }

    
    class BankAccount
    {
       
        private int accountNumber;
        private string accountHolderName;
        private string accountType;
        private double balance;

        
        public BankAccount(int accountNumber, string accountHolderName, string accountType, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
            this.balance = initialBalance;
        }

        
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} into account {accountNumber}.");
        }

       
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account {accountNumber}.");
            }
            else
            {
                
                throw new InsufficientBalanceException(accountNumber, accountHolderName, accountType);
            }
        }

        
        public double GetBalance()
        {
            Console.WriteLine($"Current balance in account {accountNumber}: {balance}");
            return balance;
        }
    }

    class Question3
    {
        static void Main()
        {
            try
            {
               
                BankAccount account = new BankAccount(123456, "Sahana", "Savings", 1000);

                
                account.Deposit(500);
                account.Withdraw(300);
                account.GetBalance();
                account.Withdraw(1500);
                account.GetBalance();
            }
            catch (InsufficientBalanceException ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
