using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The Order class includes properties for OrderPrimary, OrderTime, OrderId, Store, Product, Customer, and Quantity.
// The OrderPrimary property is a static counter variable for generating primary keys.
// The OrderTime property is a DateTime object t hat represents the time the order was placed.
// The OrderId property is a Guid object that represents the order ID.
namespace Prj1
{
    public class Order
    {
        private static int OrderCounter = 0; // Static counter variable for generating primary keys

        public int OrderPrimary { get; private set; }
        public DateTime OrderTime { get; set; }
        public Guid OrderId { get; set; }
        public string Location { get; set; }
        public Product Product { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public int Quantity { get; set; }
        public string StoreLocation { get; set; } // Added StoreLocation property
        public StoreData Store { get; set; } // Update the type to StoreData

        public Order()
        {
            OrderPrimary = GeneratePrimaryKey();
            OrderTime = DateTime.Now;
            OrderId = Guid.NewGuid();
        }

        private static int GeneratePrimaryKey()
        {
            return ++OrderCounter;
        }
    }

    public class OrderHistory
    {
        public List<Order> Orders { get; }

        public OrderHistory()
        {
            Orders = new List<Order>();
        }
    }
}