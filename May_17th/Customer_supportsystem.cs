using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface ICustomerSupportSystem
    {
        void CreateTicket(string issue);
        void ResolveTicket(int ticketId );
    }
     class EmailSupport : ICustomerSupportSystem
    {
        public void CreateTicket(string issue)
        {
            Console.WriteLine($"Email ticket created for issue: {issue}");
        }
        public void ResolveTicket(int ticketId)
        {
            Console.WriteLine($"Email ticket {ticketId} resolved.");
        }
    }
    class PhoneSupport : ICustomerSupportSystem
    {
        public void CreateTicket(string issue)
        {
            Console.WriteLine($"Phone ticket created for issue: {issue}");
        }
        public void ResolveTicket(int ticketId)
        {
            Console.WriteLine($"Phone ticket {ticketId} resolved.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerSupportSystem emailSupport = new EmailSupport();
            emailSupport.CreateTicket("Unable to login");
            emailSupport.ResolveTicket(1);
            ICustomerSupportSystem phoneSupport = new PhoneSupport();
            phoneSupport.CreateTicket("Payment issue");
            phoneSupport.ResolveTicket(2);
        }
    }
}
