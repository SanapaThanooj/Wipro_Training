using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    interface IOrder
    {
        string PlaceOrder(string item);
        string CancelOrder(string item);
    }

    class DineInOrder : IOrder
    {
        public string PlaceOrder(string item)
        {
            return $"Placeing  dine-in order for item : {item}.";
        }
        public string CancelOrder(string item)
        {
            return $"Canceling Dine-in order for item: {item} ";
        }

    }
    class TakeAwayOrder : IOrder
    {
        public string PlaceOrder(string item)
        {
            return $"Placing takeway order for item :{item}.";
        }
        public string CancelOrder(string item)
        {
            return $"Canceling takeway order for item :{item}.";
        }

    }
    class Program 
    {   static void Main() 
        {
            IOrder Dinein = new DineInOrder();
            IOrder takeaway = new TakeAwayOrder();
            Dinein.PlaceOrder("Pizza");
            Dinein.CancelOrder("Pizza");
            takeaway.PlaceOrder("Burger");
            takeaway.CancelOrder("Burger");
        }
        
    }
}
