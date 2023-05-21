using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The Inventory class includes a property Products of type Dictionary<Product, int>, 
// where Product represents the product and int represents the quantity.
namespace P1
{
    public class Inventory
    {
        public Dictionary<Product, int> Products { get; set; }

        public Store Store { get; set; }

        public Inventory(Store store)
        {
            Store = store;
            Products = new Dictionary<Product, int>();
        }
    }
}
