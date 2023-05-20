using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    public class MilkInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public MilkInventory()
        {
            store  = Stores.Walmart;
            product = new Products("MILK", 10, "ORGANIC MILK");
            quantity = 8;

        }
    }
}
