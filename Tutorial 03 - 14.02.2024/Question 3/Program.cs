using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute3._3
{
    internal class Program
    {
        class Product
        {
            private int productId;
            private string productName;
            private double price;
            private int quantityInStock;

            // Constructor
            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantityInStock = quantityInStock;
            }

            // Method to add product
            public void AddProduct()
            {
                // Implementation to add product
            }

            // Method to buy product
            public void BuyProduct()
            {
                // Implementation to buy product
            }

            // Accessor methods to retrieve product details
            public string GetProductName()
            {
                return productName;
            }

            public double GetPrice()
            {
                return price;
            }

            public int GetQuantityInStock()
            {
                return quantityInStock;
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                // Creating an instance of Product class
                Product laptop = new Product(101, "Laptop", 800, 10);

                // Accessing and displaying product details
                Console.WriteLine("Product Name: " + laptop.GetProductName());
                Console.WriteLine("Price: $" + laptop.GetPrice());
                Console.WriteLine("Quantity in Stock: " + laptop.GetQuantityInStock());

                // Attempting to modify the product's ID from external code
                // This line will cause a compilation error since productId is private
                // laptop.productId = 102;
                // Commenting out the line to prevent compilation error

                // Wait for user input before closing the console window
                Console.ReadLine();
            }
        }
    }
}
