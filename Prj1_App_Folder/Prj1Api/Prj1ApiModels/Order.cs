using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj1ApiModels
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