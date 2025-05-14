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
        public void CheckBalance();
    }
     class SavingsAccount : IBankAccount 
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing {amount} into savings account.");
        }
        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount} from savings account.");
        }
        public void CheckBalance()
        {
            Console.WriteLine("Checking balance in savings account.");
            
        }
    }
     class CurrentAccount : IBankAccount
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing {amount} into current account.");
        }
        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount} from current account.");
        }
        public void  CheckBalance()
        {
            Console.WriteLine("Checking balance in current account.");
            
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
           IBankAccount savingAccount = new SavingsAccount();
            savingAccount.Deposit(1000);
            savingAccount.Withdraw(500);
            Console.WriteLine($"Balance: {savingAccount.CheckBalance()}");
            Console.WriteLine();
            IBankAccount currentAccount = new CurrentAccount();
            currentAccount.Deposit(2000);
            currentAccount.Withdraw(1000);
            Console.WriteLine($"Balance: {currentAccount.CheckBalance()}");
            Console.WriteLine();
        }
    }
}

}
