using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    public class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 0; 
        }

        public void Credit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount for deposit.");
                Console.ReadKey();
                return;
            }
            balance += amount;
        }

        public void Debit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount for withdrawal.");
                Console.ReadKey();
                return;
            }
            if (balance < amount)
            {
                Console.WriteLine("Insufficient balance.");
                Console.ReadKey();
                return;
            }
            balance -= amount;
        }

        public void UpdateBalance()
        {
            if (transactionType == 'D')
                Credit(amount);
            else if (transactionType == 'W')
                Debit(amount);
            else
                Console.WriteLine("Invalid transaction type.");
            Console.ReadKey();
        }

        public void ShowData()
        {
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Accounts account = new Accounts(123456, "John Doe", "Savings", 'D', 1000);

            
            account.UpdateBalance();

            
            account.ShowData();
            Console.ReadKey();
        }
    }
}
