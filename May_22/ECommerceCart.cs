using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
     class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
    class ShopingCart
    {
        List<CartItem> cartItems = new List<CartItem>();
            public void AddItem(Product product, int quantity)
        {
            CartItem cartItem = new CartItem { Product = product, Quantity = quantity };
            cartItems.Add(cartItem);
        }
        public void RemoveItem(Product product)
        {
            CartItem itemToRemove = cartItems.FirstOrDefault(item => item.Product.Id == product.Id);
            if (itemToRemove != null)
            {
                cartItems.Remove(itemToRemove);
            }
        }
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
        public void PrintCart()
        {
            Console.WriteLine("Shopping Cart:");
            foreach (var item in cartItems)
            {
                Console.WriteLine($"{item.Product.Name} - {item.Quantity} x {item.Product.Price} = {item.GetTotalPrice()}");
            }
            Console.WriteLine($"Total Price: {GetTotalPrice()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product { Id = 1, Name = "Laptop", Price = 100000 };

            var product2 = new Product { Id = 2, Name = "Phone", Price = 50000 };

            var product3 = new Product { Id = 3, Name = "Tablet", Price = 300 };
            ShopingCart cart = new ShopingCart();
            cart.AddItem(product1, 1);
            cart.AddItem(product2, 2);
            cart.AddItem(product3, 3);
            cart.PrintCart();
            cart.RemoveItem(product2);
            Console.WriteLine("After removing Phone:");
            cart.PrintCart();
        }
    }
}
