using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    abstract class Notification
    {
        public abstract void Send();
        public string ShowType()
        {
            return "sending Notification";
        }
    }
     class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }
    class SMSNotification : Notification 
    {
        public override void Send()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }
}


using May_12th;

class Program
{
    static void Main()
    {
        
        Notification notification = new EmailNotification();
        notification.Send();
        Console.WriteLine(notification.ShowType());
        notification = new SMSNotification();
        notification.Send();
        Console.WriteLine(notification.ShowType()); 

    }
}

