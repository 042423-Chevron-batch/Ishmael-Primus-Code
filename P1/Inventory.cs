using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// A class called "Inventory" that stores information about a product's inventory in a store. 
// It has properties for the product name, store name, price, and quantity. 
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

    //  A class called "MilkInventory" that stores information about the inventory of milk products.
    //  It has properties for the store name, the milk product itself (including its name, price, and description), and the quantity of milk available.
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

    // A class called "BreadInventory" that stores information about the inventory of bread products.
    // It has properties for the store name, the bread product itself (including its name, price, and description), and the quantity of bread available.
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
    // A class called "CerealInventory" that stores information about the inventory of cereal products. 
    // It has properties for the store name, the cereal product itself (including its name, price, and description), and the quantity of cereal available.
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

    // A class called "IcecreamInventory" that stores information about the inventory of icecreamproducts. 
    // It has properties for the store name, the icecream product itself (including its name, price, and description), and the quantity of icecream available.
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

    // A class called "PizzaInventory" that stores information about the inventory of pizza products.
    // It has properties for the store name, the pizza product itself (including its name, price, and description), and the quantity of pizza available.
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

    // A class called "CakeInventory" that stores information about the inventory of cake products. 
    //It has properties for the store name, the milk product itself (including its name, price, and description), and the quantity of cake available.
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

    // A class called "SaladInventory" that stores information about the inventory of salad products.
    // It has properties for the store name, the salad product itself (including its name, price, and description), and the quantity of salad available.
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

    //A class called "ChickenInventory" that stores information about the inventory of chicken. 
    // It has properties for the store name, the chicken product itself (including its name, price, and description), and the quantity of chicken available.
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

    // A class called "FishInventory" that stores information about the inventory of fish products. 
    // It has properties for the store name, the fish product itself (including its name, price, and description), and the quantity of fish available.
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
