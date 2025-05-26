using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    public abstract class PaymentGateway
    {
        public string GatewayName { get; set; }
        public PaymentGateway(string name)
        {
            GatewayName = name;
        }
        public virtual bool Validate()
        {
            Console.WriteLine($"Validating payment through {GatewayName}...");
            return true;
        }

    }
    public class razorpay : PaymentGateway, IPaymentProcessor
    {
        public razorpay() : base("Razorpay") { }
        public void ProcessPayment(decimal amount)
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment of {amount:C} through {GatewayName}...");
            }
            else
            {
                Console.WriteLine("Payment validation failed.");
            }
        }
    }
    public class PayPal : PaymentGateway, IPaymentProcessor
    {
        public PayPal() : base("PayPal") { }
        public void ProcessPayment(decimal amount)
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment of {amount:C} through {GatewayName}...");
            }
            else
            {
                Console.WriteLine("Payment validation failed.");
            }
        }

    }
    public class Stripe : PaymentGateway, IPaymentProcessor
    {
        public Stripe() : base("Stripe") { }
        public void ProcessPayment(decimal amount)
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment of {amount:C} through {GatewayName}...");
            }
            else
            {
                Console.WriteLine("Payment validation failed.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IPaymentProcessor> paymentProcessors = new List<IPaymentProcessor>
            {
                new razorpay(),
                new PayPal(),
                new Stripe()
            };
            decimal[] amount = { 1500.00m, 200.00m, 350.00m };
            for (int i = 0; i < paymentProcessors.Count; i++)
            {

                paymentProcessors[i].ProcessPayment(amount[i]);

            }
        }
    }

}
