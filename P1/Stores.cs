using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1
{
    // An enum is as user-defined data type.
    // ex. an integer has valid values of 1, 22, 43, 786, but NOT 34.1
    // enum for stores 
    public enum Stores
    {
        Walmart = 0,
        Kroger = 1,
        HEB = 2,
    }

    // enum for locations of stores (value doesnt need to be defined, default will be in place)
    public enum Locations
    {
        Sugarland,
        Katy,
        Richmond
    }

    //  A class called "WalmartSugarland" that stores information about a Walmart store located in Sugarland. It has properties for the store name, location, and inventory of different products such as milk, bread, and cereal.
    //  The constructor method initializes these properties with default values. 
    public class WalmartSugarland
    {
        public Stores Store { get; set; }
        public Locations Location { get; set; } 
        public MilkInventory milkInventory { get; set; }
        public BreadInventory breadInventory { get; set; }
        public CerealInventory cerealInventory { get; set; }

        public WalmartSugarland ()
        {
        store = Stores.Walmart;
        Location = Locations.Sugarland;
        milkInventory = MilkInventory.product;
        milkInventory = MilkInventory.quantity;
        breadInventory = BreadInventory.product;
        breadInventory = BreadInventory.quantity;
        cerealInventory = CerealInventory.product;
        cerealInventory = CerealInventory.quantity;
        }
    }

    //  A class called "KrogerRichmond" that stores information about a Kroger store located in Sugarland. It has properties for the store name, location, and inventory of different products such as ice-cream, pizza, and cake.
    //  The constructor method initializes these properties with default values. 
    public class KrogerRichmond
    {
        public Stores Store { get; set; }
        public Locations Location { get; set; } 
        public IcecreamInventory icecreamInventory { get; set; }
        public PizzaInventory pizzaInventory { get; set; }
        public CakeInventory  cakeInventory { get; set; }

        public KrogerRichmond ()
        {
        store = Stores.Kroger;
        Location = Locations.Richmond;
        icecreamInventory = IcecreamInventory.product;
        icecreamInventory = IcecreamInventory.quantity;
        pizzaInventory = PizzaInventory.product;
        pizzaInventory = PizzaInventory.quantity;
        cakeInventory = CakeInventory.product;
        cakeInventory = CakeInventory.quantity;
        }
    }

    // A class called "HEBKaty" that stores information about HEB store located in Katy. It has properties for the store name, location, and inventory of different products such as salad, chicken, and fish.
    //  The constructor method initializes these properties with default values. 
    public class HEBKaty
    {
        public Stores Store { get; set; }
        public Locations Location { get; set; } 
        public SaladInventory saladInventory { get; set; }
        public ChickenInventory chickenInventory { get; set; }
        public FishInventory  fishInventory { get; set; }

        public HEBKaty ()
        {
        store = Stores.HEB;
        Location = Locations.Katy;
        saladInventory = SaladInventory.product;
        saladInventory = SaladInventory.quantity;
        chickenInventory = ChickenInventory.product;
        chickenInventory = ChickenInventory.quantity;
        fishInventory = FishInventory.product;
        fishInventory = FishInventory.quantity;
        }
    }

    
}
