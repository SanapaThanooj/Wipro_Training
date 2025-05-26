using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Threads
{
    public class Transcation
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Date:u}|{Type}|{Amount}";
        }
        public static Transcation FromString(string line)
        {
            var parts = line.Split('|');
            return new Transcation
            {
                Date = DateTime.Parse(parts[0]),
                Type = parts[1],
                Amount = decimal.Parse(parts[2])
            };
        }
    }
    class BankAccount
    {
        public string AccountHolder { get; set; }
        private List<Transcation> transactions = new List<Transcation>();
        private decimal balance = 0;
        public void Deposit(decimal amount)
        {
            balance += amount;
            transactions.Add(new Transcation
            {
                Date = DateTime.Now,
                Type = "Deposit",
                Amount = amount
            });
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                transactions.Add(new Transcation
                {
                    Date = DateTime.Now,
                    Type = "Withdraw",
                    Amount = amount
                });
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }

        }


        public void SaveTransactions(string filePath)
        {
            File.WriteAllLines(filePath, transactions.Select(t => t.ToString()));
        }
        public void LoadTransactions(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                transactions = lines.Select(Transcation.FromString).ToList();
                balance = transactions.Sum(t => t.Type == "Deposit" ? t.Amount : -t.Amount);
            }
            else
            {
                Console.WriteLine("Transaction file not found.");
            }
        }
        public void DisplaySummary()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Current Balance: {balance:C}");
            Console.WriteLine("Transaction History:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"{transaction.Date:u} | {transaction.Type} | {transaction.Amount:C}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount { AccountHolder = "John Doe" };
            account.Deposit(1000);
            account.Withdraw(200);
            account.SaveTransactions("transactions.txt");
            BankAccount newAccount = new BankAccount { AccountHolder = "Jane Smith" };
            newAccount.LoadTransactions("transactions.txt");
            newAccount.DisplaySummary();
        }
    }


}
