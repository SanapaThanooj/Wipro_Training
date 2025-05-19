using System;

namespace PaymentProcessing
{
   
    public abstract class PaymentMethod
    {
        protected string Method;

        public abstract void ProcessPayment(decimal amount);

        public void ShowPaymentMethod()
        {
            Console.WriteLine($"Payment Method: {Method}");
        }
    }

    
    public class CreditCardPayment : PaymentMethod
    {
        public CreditCardPayment()
        {
            Method = "Credit Card";
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ₹{amount}");
        }
    }

  
    public class UPIPayment : PaymentMethod
    {
        public UPIPayment()
        {
            Method = "UPI";
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of ₹{amount}");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            
            PaymentMethod creditCard = new CreditCardPayment();
            PaymentMethod upi = new UPIPayment();

            
            Console.WriteLine("--- Credit Card Payment ---");
            creditCard.ShowPaymentMethod();
            creditCard.ProcessPayment(1500.75m);

            Console.WriteLine("\n--- UPI Payment ---");
            upi.ShowPaymentMethod();
            upi.ProcessPayment(900.50m);
        }
    }
}
