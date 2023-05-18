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
    public class BreadInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public BreadInventory()
        {
            store  = Stores.Walmart;
            product = new Products("BREAD", 8, "ORGANIC BREAD");
            quantity = 5;

        }
    }
    public class CerealInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public CerealInventory()
        {
            store  = Stores.Walmart;
            product = new Products("CEREAL", 8, "GMO CEREAL");
            quantity = 3;

        }
    }
    public class IcecreamInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public IcecreamInventory()
        {
            store  = Stores.Kroger;
            product = new Products("ICECREAM", 7, "ORGANIC ICECREAM");
            quantity = 5;

        }
    }
    public class PizzaInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public PizzaInventory()
        {
            store  = Stores.Kroger;
            product = new Products("PIZZA", 8, "CHEESE PIZZA");
            quantity = 11;

        }
    }
    public class CakeInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public CakeInventory()
        {
            store  = Stores.Kroger;
            product = new Products("CAKE", 12, "CHOCLATE CAKE");
            quantity = 8;

        }
    }
    public class SaladInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public SaladInventory()
        {
            store  = Stores.HEB;
            product = new Products("SALAD", 4, "CHICKEN SALAD");
            quantity = 3;

        }
    }
    public class ChickenInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public ChickenInventory()
        {
            store  = Stores.HEB;
            product = new Products("CHICKEN", 12, "BBQ CHICKEN");
            quantity = 12;

        }
    }
    public class FishInventory
    {
        public Stores store { get; set; }
        public Products product { get; set; }
        public int quantity { get; set; }


        public FishInventory()
        {
            store  = Stores.HEB;
            product = new Products("FISH", 18, "RED SNAPPER");
            quantity = 15;

        }
    }
    
}
