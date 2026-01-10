using System;
using System.Collections.Generic;


using ShopingSystem.model;

namespace ShopingSystem.service
{

	class ShoppingService
    {
		private List<Product> pro=new List<Product>();
		private List<Product> cart = new List<Product>();

	


		public ShoppingService() {
            pro.Add(new Product(1, "Mobile", 15000));
            pro.Add(new Product(2, "Laptop", 55000));
            pro.Add(new Product(3, "Headphones", 2500));
            pro.Add(new Product(4, "Keyboard", 1200));

        }

		public void showProduct()
		{

            Console.WriteLine("\n--- Available Products ---");
            foreach (var p in pro)
            {
                Console.WriteLine($"{p.Id}. {p.Name} - ₹{p.Price}");
            }
        }
        public void AddToCard()
        {
            try
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());

                Product product = pro.Find(p => p.Id == id);

                if (product == null)
                    throw new Exception("Product not found");

                cart.Add(product);
                Console.WriteLine("Product added to cart");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input. Enter numbers only.");
                Console.WriteLine(ex.Message);

            }


        }

        public void RemoveFormCart()
        {
            try
            {
                Console.Write("Enter Product ID to remove: ");
                int id = int.Parse(Console.ReadLine());

                Product product = cart.Find(p => p.Id == id);

                if (product == null)
                    throw new Exception("Product not found in cart");

                cart.Remove(product);
                Console.WriteLine("Product removed from cart");

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

        }

        public void viewCard()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }

            int total = 0;
            Console.WriteLine("\n--- Cart Items ---");
            foreach (var p in cart)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
                total += p.Price;
            }

            Console.WriteLine("Total Amount: ₹" + total);
        }


        public void PlaceOrder()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty. Cannot place order.");
                return;




            }

            cart.Clear();
            Console.WriteLine("Order placed successfully!");
        }
    }


}