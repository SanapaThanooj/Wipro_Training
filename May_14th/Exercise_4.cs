using System;

namespace Linq_Practices
{
    abstract class FoodOrder
    {
        public abstract void PlaceOrder(string item);

        public void OrderInfo()
        {
            Console.WriteLine("placing order");
        }
    }

    class FastFoodOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"order placed for the item {item} at fast food outlet");
        }
    }

    class FineDinningOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"order placed for the item {item} at fine dinning retaurent outlet");
        }
    }

    class Program
    {
        public static void Main()
        {
            FoodOrder order;

            order = new FastFoodOrder();
            order.OrderInfo();
            order.PlaceOrder("Pizza");

            order = new FineDinningOrder();
            order.OrderInfo();
            order.PlaceOrder("Biryani");
        }
    }
}