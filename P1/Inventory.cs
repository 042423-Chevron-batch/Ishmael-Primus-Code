using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    public class Inventory
    {
        public Products product { get; set; }
        public Stores store { get; set; }
        public Products price { get; set; }
        public int Quantity { get; set; }

        public Inventory(Products product, Stores store, Products price, int quantity)
        {
            Products = product;
            Stores = store;
            Products = price;
            Quantity = quantity;
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
