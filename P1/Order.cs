using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The Order class includes properties for OrderPrimary, OrderTime, OrderId, Store, Product, Customer, and Quantity.
// The OrderPrimary property is a static counter variable for generating primary keys.
// The OrderTime property is a DateTime object t hat represents the time the order was placed.
// The OrderId property is a Guid object that represents the order ID.
namespace P1
{
    public class Order
    {
        private static int OrderCounter = 0; // Static counter variable for generating primary keys

        public int OrderPrimary { get; private set; }
        public DateTime OrderTime { get; set; }
        public Guid OrderId { get; set; }
        public Store Store { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public int Quantity { get; set; }

        public Order()
        {
            OrderPrimary = Order.GeneratePrimaryKey();
            OrderTime = DateTime.Now;
            OrderId = Guid.NewGuid();

        }

        private static int GeneratePrimaryKey()
        {
            return ++OrderCounter;
        }
    }
}