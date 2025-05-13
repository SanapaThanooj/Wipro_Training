using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    abstract class PaymentGateway
    {
        public abstract void ProcessPayment(decimal amount);
        public  void ShowGatewayName()
        {
            Console.WriteLine("Processing Payment through  Gateway");
        }
    }
     class StripeGateway : PaymentGateway
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment through Stripe :{amount}");
        }
    }
    class PayPalGateway : PaymentGateway
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment through PayPal :{amount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
{
    PaymentGateway stripGateway = new StripeGateway();
    PaymentGateway paypalGateway = new PayPalGateway();

    stripGateway.ShowGatewayName();
    stripGateway.ProcessPayment(1500);
    paypalGateway.ShowGatewayName();
    paypalGateway.ProcessPayment(2700);

}
    }
}
