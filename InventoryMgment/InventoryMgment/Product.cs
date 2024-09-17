using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Ernesto 


namespace InventoryMgment
{
    public  class Product
    {
        public string Name 
        { 
            get;
            set;
        }
        public decimal Price
        { 
            get; 
            set;
        }
        public int Stock
        { 
            get; 
            set;
        }
    };

    public class InventoryManager
    {
        public List<Product> SortProducts(List<Product> products, string sortKey, bool ascending)
        {
            IEnumerable<Product> sortedProducts = null;

            switch (sortKey.ToLower())
            {
                case "name":
                    sortedProducts = ascending ? products.OrderBy(p => p.Name) : products.OrderByDescending(p => p.Name);
                    break;
                case "price":
                    sortedProducts = ascending ? products.OrderBy(p => p.Price) : products.OrderByDescending(p => p.Price);
                    break;
                case "stock":
                    sortedProducts = ascending ? products.OrderBy(p => p.Stock) : products.OrderByDescending(p => p.Stock);
                    break;
                default:
                    throw new ArgumentException("Invalid sort key.");
            }

            return sortedProducts.ToList();
        }
    }
}
