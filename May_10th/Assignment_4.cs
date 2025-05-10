using System;

namespace PaymentSystem
{
    class Payment
    {
        public decimal Amount;
        public string Currency;

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }

        public void ProcessPayment(decimal amount)
        {
            Amount = amount;
            Currency = "USD";
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }

        public void ProcessPayment(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }
    }

    class CreditCardPayment : Payment
    {
        public string CardNumber;

        public override void ProcessPayment()
        {
            Console.WriteLine($"Credit Card Payment: {Amount} {Currency}, Card Number: **** **** **** {CardNumber.Substring(CardNumber.Length - 4)}");
        }
    }

    class PayPalPayment : Payment
    {
        public string EmailAddress;

        public override void ProcessPayment()
        {
            Console.WriteLine($"PayPal Payment: {Amount} {Currency}, Email: {EmailAddress}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment ccPayment = new CreditCardPayment();
            ccPayment.CardNumber = "1234567890123456";
            ccPayment.ProcessPayment(100);
            ccPayment.ProcessPayment();

            PayPalPayment ppPayment = new PayPalPayment();
            ppPayment.EmailAddress = "user@example.com";
            ppPayment.ProcessPayment(75.50m, "EUR");
            ppPayment.ProcessPayment();
        }
    }
}