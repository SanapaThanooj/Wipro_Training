using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }
    class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}


using May_12th;

class Program
{
    static void Main()
    {
        IPayment Payment;
        Payment  = new CreditCardPayment();
        Payment.ProcessPayment(100.50m);

        Payment = new PayPalPayment();
        Payment.ProcessPayment(200.75m);
    }
}
