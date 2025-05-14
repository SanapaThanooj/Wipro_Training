using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    abstract class TicketBooking 
    {
        abstract public void BookTicket(int seats);
        public void ShowBookingInfo()
        {
            Console.WriteLine("booking Ticket");
        }
    }
     class BusBooking : TicketBooking
    {
        public override void BookTicket(int seats)
        {
            Console.WriteLine("Booking X Bus Tickets");
        }
    
    }
     class FlightBooking : TicketBooking
    {
        public override void BookTicket(int seats)
        {
            Console.WriteLine("Booking X Flight Tickets");
        }
    }
}
namespace Linq_Practices
{
    class Program
    {
        static void Main(string[] args)
        {
           TicketBooking busBooking = new BusBooking();
            busBooking.BookTicket(5);
            busBooking.ShowBookingInfo();
           TicketBooking fltBooking = new FlightBooking();
            fltBooking.BookTicket(2);
            fltBooking.ShowBookingInfo();
        }
    }
}