using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    interface IBankAccount 
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
         void CheckBalance();
    }
     class SavingsAccount : IBankAccount 
    {
        private decimal balance = 0;
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Depositing {amount} into savings account.");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawing {amount} from savings account.");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("Checking balance in savings account.");
            
        }
    }
     class CurrentAccount : IBankAccount
    {
        private decimal balance = 0;
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Depositing {amount} into current account.");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawing {amount} from current account.");
            }
        }
        public void  CheckBalance()
        {
            Console.WriteLine("Checking balance in current account.");
           
        }
    }
       
}
namespace Linq_Practices
{
    class Program
    {
        static void Main(string[] args)
        {
           IBankAccount savingAccount = new SavingsAccount();
            savingAccount.Deposit(1000);
            savingAccount.Withdraw(500);
            savingAccount.CheckBalance();
            Console.WriteLine();
            IBankAccount currentAccount = new CurrentAccount();
            currentAccount.Deposit(2000);
            currentAccount.Withdraw(1000);
            currentAccount.CheckBalance();
            Console.WriteLine();
        }
    }
}