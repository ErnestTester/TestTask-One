using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMgment
{
    class Program
    {

        static void Main(string[] args)
        {
            var products = new List<Product>
            {
            new Product { Name = "Product A", Price = 100, Stock = 5 },
            new Product { Name = "Product B", Price = 200, Stock = 3 },
            new Product { Name = "Product C", Price = 50, Stock = 10 },
            new Product { Name = "Product D", Price = 1000, Stock = 2 }
            };


            InventoryManager inventoryManager = new InventoryManager();

            var sortedProducts = inventoryManager.SortProducts(products, "price", false);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
            foreach (var product in sortedProducts)
            {
                Console.WriteLine( $"Price: { product.Price}, Name: {product.Name}");
            }
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Stock: {product.Stock}, Name: {product.Name}");
            }
        }
    }
}
